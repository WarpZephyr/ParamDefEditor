using SoulsFormats;
using System;
using System.IO;
using System.Windows.Forms;
using Utilities;
using CustomForms;
using System.Collections.Generic;
using System.Drawing;

namespace ParamDefEditor
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// The currently selected def to store for editing and to restore in case of issues.
        /// </summary>
        private DefWrapper DefStore;

        /// <summary>
        /// The currently selected field to store for editing and to restore in case of issues.
        /// </summary>
        private FieldWrapper FieldStore;

        /// <summary>
        /// The field type of the current field being edited, to restore in case of issues.
        /// </summary>
        private string FieldTypeStore;

        /// <summary>
        /// The copied defs currently being held for pasting.
        /// </summary>
        private List<DefWrapper> CopiedDefs;

        /// <summary>
        /// The copied fields currently being held for pasting.
        /// </summary>
        private List<FieldWrapper> CopiedFields;

        public MainForm()
        {
            InitializeComponent();
            
            SelectableColorToolStripRenderer menuRenderer = new SelectableColorToolStripRenderer();
            MainFormMenuStrip.Renderer = menuRenderer;
            MainToolStrip.Renderer = menuRenderer;
            FileContextMenu.Renderer = menuRenderer;
            DefContextMenu.Renderer = menuRenderer;

            ((ToolStripDropDownMenu)MenuFile.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)MenuEdit.DropDown).ShowImageMargin = false;
            FileContextMenu.ShowImageMargin = false;
            DefContextMenu.ShowImageMargin = false;
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            string[] paths = PathUtil.GetFilePaths("C:\\Users", "Select Param Defs", "Def file (*.def)|*.def|All files (*.*)|*.*");
            if (paths == null)
            {
                StatusLabel.Text = "Canceled opening defs.";
                return;
            }
            FileHandler(paths);
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            bool save = FormUtil.ShowQuestionDialog("Are you sure you wish to save the currently selected def?", "Save Def");
            if (!save)
                return;

            string name = FileDGV.CurrentRow.Cells[0].Value.ToString();
            if (DefStore.Modified == true || !File.Exists(DefStore.Path))
            {
                PathUtil.Backup(DefStore.Path);
                DefStore.Write();
                DefStore.Modified = false;
                StatusLabel.Text = $"Saved {name}.";
            }
            else
            {
                StatusLabel.Text = $"{name} has not been modified since its last save time.";
            }
        }

        private void MenuSaveAll_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            bool save = FormUtil.ShowQuestionDialog("Are you sure you wish to save all modified defs?", "Save All Defs");
            if (!save)
                return;

            int total = FileDGV.Rows.Count;
            int count = 0;
            int noCount = 0;
            foreach (DataGridViewRow row in FileDGV.Rows)
            {
                DefWrapper def = row.Cells[0].Value as DefWrapper;
                if (def.Modified || !File.Exists(def.Path))
                {
                    PathUtil.Backup(def.Path);
                    def.Write();
                    def.Modified = false;
                    count++;
                }
                else
                {
                    noCount++;
                }
            }

            StatusLabel.Text = $"Saved {count} defs, {noCount} defs have not been modified since last save, {total - (count + noCount)} defs failed to save.";
        }

        private void MenuClose_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            bool close = FormUtil.ShowQuestionDialog("Are you sure you wish to close the currently selected param def?", "Close Def");
            if (!close)
                return;

            string name = FileDGV.CurrentRow.Cells[0].Value.ToString();
            FileDGV.Rows.Remove(FileDGV.CurrentRow);
            if (FileDGV.Rows.Count == 0)
                DefDGV.Rows.Clear();

            StatusLabel.Text = $"Removed {name}.";
        }

        private void MenuCloseAll_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            bool close = FormUtil.ShowQuestionDialog("Are you sure you wish to close all param defs?", "Close All Defs");
            if (!close)
                return;

            FileDGV.Rows.Clear();
            DefDGV.Rows.Clear();
            StatusLabel.Text = "Removed all defs.";
        }

        private void MenuCreate_Click(object sender, EventArgs e)
        {
            bool created = false;
            using (NewDefForm form = new NewDefForm())
            {
                form.ShowDialog();
                if (form.DefCreated)
                {
                    DefWrapper defWrapper = form.Def;
                    FileDGV.Rows.Add(new object[] { defWrapper, defWrapper.Type });
                    StatusLabel.Text = $"Created {defWrapper.Name}.";
                    created = true;
                }
            }
            if (!created)
                StatusLabel.Text = "Canceled creating a new def.";
        }

        private void MenuCopyDefs_Click(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            var selected = new List<DefWrapper>();
            foreach (DataGridViewRow row in FileDGV.SelectedRows)
                selected.Add(row.Cells[0].Value as DefWrapper);

            var copies = new List<DefWrapper>();
            for (int i = 0; i < selected.Count; i++)
            {
                var def = selected[i];
                var newDef = new DefWrapper();
                newDef.Type = def.Type;
                newDef.Def = CopyDef(def.Def);
                newDef.Modified = true;

                string extension = Path.GetExtension(def.Path);
                string extensionlessName = Path.GetFileNameWithoutExtension(def.Path);
                string folder = Path.GetDirectoryName(def.Path);
                int appendNum = i;
                do
                {
                    string name = $"{extensionlessName}{appendNum}{extension}";
                    newDef.Path = $"{folder}\\{name}";
                    newDef.Name = name;
                    appendNum++;
                } while (File.Exists(newDef.Path));

                copies.Add(newDef);
            }

            CopiedDefs = copies;
            StatusLabel.Text = $"Copied {copies.Count} defs.";
        }

        private void MenuPasteDefs_Click(object sender, EventArgs e)
        {
            if (CopiedDefs == null)
                return;

            foreach (var def in CopiedDefs)
                FileDGV.Rows.Add(new object[] { def, def.Type });

            StatusLabel.Text = $"Pasted {CopiedDefs.Count} defs.";
        }

        private void MenuCopyFields_Click(object sender, EventArgs e)
        {
            if (DefDGV.CurrentRow == null)
                return;

            var selected = new List<FieldWrapper>();
            foreach (DataGridViewRow row in DefDGV.SelectedRows)
                selected.Add(row.Cells[1].Value as FieldWrapper);

            var copies = new List<FieldWrapper>();
            for (int i = 0; i < selected.Count; i++)
                copies.Add(new FieldWrapper(CopyDefField(selected[i].Field)));

            CopiedFields = copies;
            StatusLabel.Text = $"Copied {copies.Count} def fields.";
        }

        private void MenuPasteFields_Click(object sender, EventArgs e)
        {
            if (CopiedFields == null)
                return;

            foreach (var field in CopiedFields)
            {
                DefDGV.Rows.Add(new object[] { field.Type, field });
                DefStore.Def.Fields.Add(field.Field);
            }

            DefStore.Modified = true;
            StatusLabel.Text = $"Pasted {CopiedFields.Count} def fields.";
        }

        private void MenuDeleteFields_Click(object sender, EventArgs e)
        {
            if (DefDGV.CurrentRow == null || DefDGV.Rows.Count == 1)
                return;

            int selectedCount = DefDGV.SelectedRows.Count;
            if (selectedCount >= DefDGV.Rows.Count)
                return;

            bool delete = FormUtil.ShowQuestionDialog("Are you sure you wish to delete the currently selected param def fields?", "Delete Fields");
            if (!delete)
                return;
            
            foreach (DataGridViewRow row in DefDGV.SelectedRows)
            {
                var field = row.Cells[1].Value as FieldWrapper;
                DefDGV.Rows.Remove(row);
                DefStore.Def.Fields.Remove(field.Field);
            }
            
            DefStore.Modified = true;
            StatusLabel.Text = $"Deleted {selectedCount} param def fields.";
        }

        private void MenuCreateField_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet supported.");
        }

        private void MenuExportDef_Click(object sender, EventArgs e)
        {
            if (DefDGV.CurrentRow == null)
                return;

            UpdateExportStatus("def", ExportHandler(Exporter.ExportType.Def));
        }

        private void MenuExportXml_Click(object sender, EventArgs e)
        {
            if (DefDGV.CurrentRow == null)
                return;

            UpdateExportStatus("xml", ExportHandler(Exporter.ExportType.Xml));
        }

        private void MenuExportTxt_Click(object sender, EventArgs e)
        {
            if (DefDGV.CurrentRow == null)
                return;

            UpdateExportStatus("txt", ExportHandler(Exporter.ExportType.Txt));
        }

        private void ContextOpen_Click(object sender, EventArgs e)
        {
            MenuOpen_Click(sender, e);
        }

        private void ContextSave_Click(object sender, EventArgs e)
        {
            MenuSave_Click(sender, e);
        }

        private void ContextSaveAll_Click(object sender, EventArgs e)
        {
            MenuSaveAll_Click(sender, e);
        }

        private void ContextClose_Click(object sender, EventArgs e)
        {
            MenuClose_Click(sender, e);
        }

        private void ContextCloseAll_Click(object sender, EventArgs e)
        {
            MenuCloseAll_Click(sender, e);
        }

        private void ContextCreate_Click(object sender, EventArgs e)
        {
            MenuCreate_Click(sender, e);
        }

        private void ContextCopyDefs_Click(object sender, EventArgs e)
        {
            MenuCopyDefs_Click(sender, e);
        }

        private void ContextPasteDefs_Click(object sender, EventArgs e)
        {
            MenuPasteDefs_Click(sender, e);
        }

        private void ContextCopyFields_Click(object sender, EventArgs e)
        {
            MenuCopyFields_Click(sender, e);
        }

        private void ContextPasteFields_Click(object sender, EventArgs e)
        {
            MenuPasteFields_Click(sender, e);
        }

        private void ContextDeleteFields_Click(object sender, EventArgs e)
        {
            MenuDeleteFields_Click(sender, e);
        }

        private void ContextCreateField_Click(object sender, EventArgs e)
        {
            MenuCreateField_Click(sender, e);
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            FileHandler((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void FileDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            DefDGV.Rows.Clear();

            DefWrapper selectedDef = FileDGV.CurrentRow.Cells[0].Value as DefWrapper;
            DefStore = selectedDef;

            foreach (var field in selectedDef.Def.Fields)
            {
                var fieldWrapper = new FieldWrapper(field);
                DefDGV.Rows.Add(new object[] { fieldWrapper.Type, fieldWrapper, fieldWrapper.Description });
            }
        }

        private void DefDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DefDGV.CurrentRow == null)
                return;

            FieldStore = DefDGV.CurrentRow.Cells[1].Value as FieldWrapper;
        }

        private void FileDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (FileDGV.CurrentRow == null)
                return;

            DefWrapper selectedDef = DefStore;

            switch (e.ColumnIndex)
            {
                case 0:
                    string name = FileDGV.CurrentRow.Cells[0].Value.ToString();
                    selectedDef.Name = name;
                    FileDGV.CurrentRow.Cells[0].Value = DefStore;
                    selectedDef.Modified = true;
                    break;
                case 1:
                    string type = FileDGV.CurrentRow.Cells[1].Value.ToString();
                    selectedDef.Type = type;
                    selectedDef.Modified = true;
                    break;
            }
        }

        private void DefDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DefDGV.CurrentRow == null)
                return;

            switch (e.ColumnIndex)
            {
                case 0:
                    string enumStr = DefDGV.CurrentRow.Cells[0].Value.ToString();
                    bool parsed = Enum.TryParse(enumStr, false, out DefType type);
                    if (!parsed)
                    {
                        DefDGV.CurrentRow.Cells[0].Value = FieldTypeStore;
                        return;
                    }
                    FieldStore.Type = type;
                    DefStore.Modified = true;
                    break;
                case 1:
                    var value1 = DefDGV.CurrentRow.Cells[1].Value;
                    string displayname = value1 != null ? value1.ToString() : "";
                    FieldStore.Name = displayname;
                    DefDGV.CurrentRow.Cells[1].Value = FieldStore;
                    DefStore.Modified = true;
                    break;
                case 2:
                    var value2 = DefDGV.CurrentRow.Cells[2].Value;
                    string description = value2 != null ? value2.ToString() : "";
                    FieldStore.Description = description;
                    DefStore.Modified = true;
                    break;
            }
        }

        private void DefDGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
                FieldTypeStore = DefDGV.CurrentRow.Cells[0].Value.ToString();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O) MenuOpen_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.S) MenuSave_Click(sender, e);
            else if (e.Control && e.Shift && e.KeyCode == Keys.S) MenuSaveAll_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.D) MenuClose_Click(sender, e);
            else if (e.Control && e.Shift && e.KeyCode == Keys.D) MenuCloseAll_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.N) MenuCreate_Click(sender, e);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var defs = new List<DefWrapper>();
            foreach (DataGridViewRow row in FileDGV.Rows)
                defs.Add(row.Cells[0].Value as DefWrapper);

            bool modified = false;
            foreach (var def in defs)
            {
                if (def.Modified || !File.Exists(def.Path))
                    modified = true;
            }

            if (modified)
            {
                bool quit = FormUtil.ShowQuestionDialog("There are still unsaved changes, do you wish to quit without saving?", "Quit Without Saving");
                if (!quit)
                {
                    e.Cancel = true;
                    StatusLabel.Text = "Canceled exiting without saving.";
                }
            }
        }

        private PARAMDEF CopyDef(PARAMDEF def)
        {
            var newDef = new PARAMDEF();
            newDef.BigEndian = def.BigEndian;
            newDef.Unicode = def.Unicode;
            newDef.Compression = def.Compression;
            newDef.DataVersion = def.DataVersion;
            newDef.FormatVersion = def.FormatVersion;
            newDef.ParamType = def.ParamType;
            foreach (var field in def.Fields)
                newDef.Fields.Add(CopyDefField(field));
            return newDef;
        }

        private PARAMDEF.Field CopyDefField(PARAMDEF.Field field)
        {
            var newField = new PARAMDEF.Field();
            newField.DisplayFormat = field.DisplayFormat;
            newField.DisplayType = field.DisplayType;
            newField.DisplayName = field.DisplayName;
            newField.InternalName = field.InternalName;
            newField.InternalType = field.InternalType;
            newField.Description = field.Description;
            newField.Default = field.Default;
            newField.Maximum = field.Maximum;
            newField.Minimum = field.Minimum;
            newField.Increment = field.Increment;
            newField.SortID = field.SortID;
            newField.EditFlags = field.EditFlags;
            newField.ArrayLength = field.ArrayLength;
            newField.BitSize = field.BitSize;
            newField.UnkC8 = field.UnkC8;
            newField.UnkC0 = field.UnkC0;
            newField.UnkB8 = field.UnkB8;
            return newField;
        }

        private void FileHandler(string[] paths)
        {
            int count = 0;
            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;

                try
                {
                    PARAMDEF def;
                    if (path.EndsWith(".xml"))
                        def = PARAMDEF.XmlDeserialize(path);
                    else if (path.EndsWith(".txt"))
                        def = TxtSerializer.TxtDeserialize(File.ReadAllLines(path));
                    else
                        def = PARAMDEF.Read(path);

                    var defWrapper = new DefWrapper(def, path);
                    FileDGV.Rows.Add(new object[] { defWrapper, defWrapper.Type });
                    count++;
                }
                catch
                {
                    continue;
                }
            }

            StatusLabel.Text = $"Loaded {count} defs out of {paths.Length} files.";
        }

        private int ExportHandler(Exporter.ExportType type)
        {
            string saveDir = PathUtil.GetFolderPath("C:\\Users", "Choose a folder to export to");
            if (saveDir == null)
                return -1;

            int count = 0;

            foreach (DataGridViewRow row in FileDGV.Rows)
            {
                DefWrapper def = row.Cells[0].Value as DefWrapper;
                string outPath = $"{saveDir}\\{def.Name}";
                PathUtil.Backup(outPath);
                def.Def.Export(type, outPath);
                count++;
            }
            return count;
        }

        private void UpdateExportStatus(string type, int count)
        {
            if (count > 0)
                StatusLabel.Text = $"Exported {count} defs to {type}.";
            else if (count == -1)
                StatusLabel.Text = $"Canceled export to {type}.";
        }
    }
}