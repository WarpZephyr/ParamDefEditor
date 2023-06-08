namespace ParamDefEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportXml = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportDef = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCopyDefs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPasteDefs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteFields = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCopyFields = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPasteFields = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreateField = new System.Windows.Forms.ToolStripMenuItem();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FileDGV = new System.Windows.Forms.DataGridView();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deftype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextCopyDefs = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextPasteDefs = new System.Windows.Forms.ToolStripMenuItem();
            this.DefDGV = new System.Windows.Forms.DataGridView();
            this.celltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celldisname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celldescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextDeleteFields = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextCopyFields = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextPasteFields = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextCreateField = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.MenuImportDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportDbp = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileDGV)).BeginInit();
            this.FileContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefDGV)).BeginInit();
            this.DefContextMenu.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1215, 24);
            this.MainFormMenuStrip.TabIndex = 0;
            this.MainFormMenuStrip.Text = "MainMenuStrip";
            // 
            // MenuFile
            // 
            this.MenuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuSave,
            this.MenuSaveAll,
            this.MenuClose,
            this.MenuCloseAll,
            this.MenuCreate,
            this.MenuFileSeparator1,
            this.MenuImport,
            this.MenuExport});
            this.MenuFile.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // MenuOpen
            // 
            this.MenuOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuOpen.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOpen.Size = new System.Drawing.Size(194, 22);
            this.MenuOpen.Text = "Open";
            this.MenuOpen.ToolTipText = "Open more param defs.";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuSave.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSave.Size = new System.Drawing.Size(194, 22);
            this.MenuSave.Text = "Save";
            this.MenuSave.ToolTipText = "Save the currently selected param def.";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuSaveAll
            // 
            this.MenuSaveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuSaveAll.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuSaveAll.Name = "MenuSaveAll";
            this.MenuSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuSaveAll.Size = new System.Drawing.Size(194, 22);
            this.MenuSaveAll.Text = "Save All";
            this.MenuSaveAll.ToolTipText = "Save all open param defs.";
            this.MenuSaveAll.Click += new System.EventHandler(this.MenuSaveAll_Click);
            // 
            // MenuClose
            // 
            this.MenuClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuClose.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.MenuClose.Size = new System.Drawing.Size(194, 22);
            this.MenuClose.Text = "Close";
            this.MenuClose.ToolTipText = "Close the currently selected param def.";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // MenuCloseAll
            // 
            this.MenuCloseAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuCloseAll.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuCloseAll.Name = "MenuCloseAll";
            this.MenuCloseAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.MenuCloseAll.Size = new System.Drawing.Size(194, 22);
            this.MenuCloseAll.Text = "Close All";
            this.MenuCloseAll.ToolTipText = "Close all open param defs.";
            this.MenuCloseAll.Click += new System.EventHandler(this.MenuCloseAll_Click);
            // 
            // MenuCreate
            // 
            this.MenuCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuCreate.Name = "MenuCreate";
            this.MenuCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuCreate.Size = new System.Drawing.Size(194, 22);
            this.MenuCreate.Text = "Create";
            this.MenuCreate.ToolTipText = "Create a new param def.";
            this.MenuCreate.Click += new System.EventHandler(this.MenuCreate_Click);
            // 
            // MenuFileSeparator1
            // 
            this.MenuFileSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuFileSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuFileSeparator1.Name = "MenuFileSeparator1";
            this.MenuFileSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // MenuExport
            // 
            this.MenuExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExportXml,
            this.MenuExportDef,
            this.MenuExportDbp,
            this.MenuExportTxt});
            this.MenuExport.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExport.Name = "MenuExport";
            this.MenuExport.Size = new System.Drawing.Size(194, 22);
            this.MenuExport.Text = "Export";
            this.MenuExport.ToolTipText = "Export various file types to other file types.";
            // 
            // MenuExportXml
            // 
            this.MenuExportXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportXml.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportXml.Name = "MenuExportXml";
            this.MenuExportXml.Size = new System.Drawing.Size(180, 22);
            this.MenuExportXml.Text = "Xml";
            this.MenuExportXml.ToolTipText = "Export defs to xml.";
            this.MenuExportXml.Click += new System.EventHandler(this.MenuExportXml_Click);
            // 
            // MenuExportDef
            // 
            this.MenuExportDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportDef.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportDef.Name = "MenuExportDef";
            this.MenuExportDef.Size = new System.Drawing.Size(180, 22);
            this.MenuExportDef.Text = "Def";
            this.MenuExportDef.ToolTipText = "Export loaded defs to def.";
            this.MenuExportDef.Click += new System.EventHandler(this.MenuExportDef_Click);
            // 
            // MenuExportTxt
            // 
            this.MenuExportTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportTxt.Name = "MenuExportTxt";
            this.MenuExportTxt.Size = new System.Drawing.Size(180, 22);
            this.MenuExportTxt.Text = "Txt";
            this.MenuExportTxt.ToolTipText = "Export loaded defs to txt.";
            this.MenuExportTxt.Click += new System.EventHandler(this.MenuExportTxt_Click);
            // 
            // MenuEdit
            // 
            this.MenuEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCopyDefs,
            this.MenuPasteDefs,
            this.MenuDeleteFields,
            this.MenuCopyFields,
            this.MenuPasteFields,
            this.MenuCreateField});
            this.MenuEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(39, 20);
            this.MenuEdit.Text = "Edit";
            // 
            // MenuCopyDefs
            // 
            this.MenuCopyDefs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuCopyDefs.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuCopyDefs.Name = "MenuCopyDefs";
            this.MenuCopyDefs.Size = new System.Drawing.Size(187, 22);
            this.MenuCopyDefs.Text = "Copy Selected Defs";
            this.MenuCopyDefs.ToolTipText = "Copy the currently selected param defs.";
            this.MenuCopyDefs.Click += new System.EventHandler(this.MenuCopyDefs_Click);
            // 
            // MenuPasteDefs
            // 
            this.MenuPasteDefs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuPasteDefs.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuPasteDefs.Name = "MenuPasteDefs";
            this.MenuPasteDefs.Size = new System.Drawing.Size(187, 22);
            this.MenuPasteDefs.Text = "Paste Selected Defs";
            this.MenuPasteDefs.ToolTipText = "Paste copied param defs if any were copied.";
            this.MenuPasteDefs.Click += new System.EventHandler(this.MenuPasteDefs_Click);
            // 
            // MenuDeleteFields
            // 
            this.MenuDeleteFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuDeleteFields.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuDeleteFields.Name = "MenuDeleteFields";
            this.MenuDeleteFields.Size = new System.Drawing.Size(187, 22);
            this.MenuDeleteFields.Text = "Delete Selected Fields";
            this.MenuDeleteFields.ToolTipText = "Delete the currently selected param def fields.";
            this.MenuDeleteFields.Click += new System.EventHandler(this.MenuDeleteFields_Click);
            // 
            // MenuCopyFields
            // 
            this.MenuCopyFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuCopyFields.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuCopyFields.Name = "MenuCopyFields";
            this.MenuCopyFields.Size = new System.Drawing.Size(187, 22);
            this.MenuCopyFields.Text = "Copy Selected Fields";
            this.MenuCopyFields.ToolTipText = "Copy the currently selected param def fields.";
            this.MenuCopyFields.Click += new System.EventHandler(this.MenuCopyFields_Click);
            // 
            // MenuPasteFields
            // 
            this.MenuPasteFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuPasteFields.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuPasteFields.Name = "MenuPasteFields";
            this.MenuPasteFields.Size = new System.Drawing.Size(187, 22);
            this.MenuPasteFields.Text = "Paste Selected Fields";
            this.MenuPasteFields.ToolTipText = "Paste copied param def fields if any were copied.";
            this.MenuPasteFields.Click += new System.EventHandler(this.MenuPasteFields_Click);
            // 
            // MenuCreateField
            // 
            this.MenuCreateField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuCreateField.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuCreateField.Name = "MenuCreateField";
            this.MenuCreateField.Size = new System.Drawing.Size(187, 22);
            this.MenuCreateField.Text = "Create Field";
            this.MenuCreateField.ToolTipText = "Create a new param def field.";
            this.MenuCreateField.Click += new System.EventHandler(this.MenuCreateField_Click);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.FileDGV);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.DefDGV);
            this.MainSplitContainer.Size = new System.Drawing.Size(1215, 417);
            this.MainSplitContainer.SplitterDistance = 477;
            this.MainSplitContainer.TabIndex = 1;
            // 
            // FileDGV
            // 
            this.FileDGV.AllowUserToAddRows = false;
            this.FileDGV.AllowUserToDeleteRows = false;
            this.FileDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.FileDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.FileDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FileDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filename,
            this.deftype});
            this.FileDGV.ContextMenuStrip = this.FileContextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.FileDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDGV.EnableHeadersVisualStyles = false;
            this.FileDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.FileDGV.Location = new System.Drawing.Point(0, 0);
            this.FileDGV.Name = "FileDGV";
            this.FileDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FileDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileDGV.Size = new System.Drawing.Size(477, 417);
            this.FileDGV.TabIndex = 0;
            this.FileDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.FileDGV_CellValueChanged);
            this.FileDGV.SelectionChanged += new System.EventHandler(this.FileDGV_SelectionChanged);
            // 
            // filename
            // 
            this.filename.HeaderText = "Name";
            this.filename.Name = "filename";
            this.filename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // deftype
            // 
            this.deftype.HeaderText = "Type";
            this.deftype.Name = "deftype";
            this.deftype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FileContextMenu
            // 
            this.FileContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextOpen,
            this.ContextSave,
            this.ContextSaveAll,
            this.ContextClose,
            this.ContextCloseAll,
            this.ContextCreate,
            this.ContextCopyDefs,
            this.ContextPasteDefs});
            this.FileContextMenu.Name = "FileContextMenu";
            this.FileContextMenu.Size = new System.Drawing.Size(218, 180);
            // 
            // ContextOpen
            // 
            this.ContextOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextOpen.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextOpen.Name = "ContextOpen";
            this.ContextOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ContextOpen.Size = new System.Drawing.Size(217, 22);
            this.ContextOpen.Text = "Open";
            this.ContextOpen.ToolTipText = "Open more param defs.";
            this.ContextOpen.Click += new System.EventHandler(this.ContextOpen_Click);
            // 
            // ContextSave
            // 
            this.ContextSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextSave.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextSave.Name = "ContextSave";
            this.ContextSave.ShortcutKeyDisplayString = "";
            this.ContextSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ContextSave.Size = new System.Drawing.Size(217, 22);
            this.ContextSave.Text = "Save";
            this.ContextSave.ToolTipText = "Save the currently selected param def.";
            this.ContextSave.Click += new System.EventHandler(this.ContextSave_Click);
            // 
            // ContextSaveAll
            // 
            this.ContextSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextSaveAll.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextSaveAll.Name = "ContextSaveAll";
            this.ContextSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ContextSaveAll.Size = new System.Drawing.Size(217, 22);
            this.ContextSaveAll.Text = "Save All";
            this.ContextSaveAll.ToolTipText = "Save all open param defs.";
            this.ContextSaveAll.Click += new System.EventHandler(this.ContextSaveAll_Click);
            // 
            // ContextClose
            // 
            this.ContextClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextClose.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextClose.Name = "ContextClose";
            this.ContextClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.ContextClose.Size = new System.Drawing.Size(217, 22);
            this.ContextClose.Text = "Close";
            this.ContextClose.ToolTipText = "Close the currently selected param def.";
            this.ContextClose.Click += new System.EventHandler(this.ContextClose_Click);
            // 
            // ContextCloseAll
            // 
            this.ContextCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextCloseAll.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextCloseAll.Name = "ContextCloseAll";
            this.ContextCloseAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.ContextCloseAll.Size = new System.Drawing.Size(217, 22);
            this.ContextCloseAll.Text = "Close All";
            this.ContextCloseAll.ToolTipText = "Close all open param defs.";
            this.ContextCloseAll.Click += new System.EventHandler(this.ContextCloseAll_Click);
            // 
            // ContextCreate
            // 
            this.ContextCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextCreate.Name = "ContextCreate";
            this.ContextCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ContextCreate.Size = new System.Drawing.Size(217, 22);
            this.ContextCreate.Text = "Create";
            this.ContextCreate.ToolTipText = "Create a new param def.";
            this.ContextCreate.Click += new System.EventHandler(this.ContextCreate_Click);
            // 
            // ContextCopyDefs
            // 
            this.ContextCopyDefs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextCopyDefs.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextCopyDefs.Name = "ContextCopyDefs";
            this.ContextCopyDefs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ContextCopyDefs.Size = new System.Drawing.Size(217, 22);
            this.ContextCopyDefs.Text = "Copy Selected Defs";
            this.ContextCopyDefs.ToolTipText = "Copy the currently selected param defs.";
            this.ContextCopyDefs.Click += new System.EventHandler(this.ContextCopyDefs_Click);
            // 
            // ContextPasteDefs
            // 
            this.ContextPasteDefs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextPasteDefs.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextPasteDefs.Name = "ContextPasteDefs";
            this.ContextPasteDefs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ContextPasteDefs.Size = new System.Drawing.Size(217, 22);
            this.ContextPasteDefs.Text = "Paste Selected Defs";
            this.ContextPasteDefs.ToolTipText = "Paste copied param defs if any were copied.";
            this.ContextPasteDefs.Click += new System.EventHandler(this.ContextPasteDefs_Click);
            // 
            // DefDGV
            // 
            this.DefDGV.AllowUserToAddRows = false;
            this.DefDGV.AllowUserToDeleteRows = false;
            this.DefDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DefDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DefDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.DefDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DefDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DefDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DefDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DefDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.celltype,
            this.celldisname,
            this.celldescription});
            this.DefDGV.ContextMenuStrip = this.DefContextMenu;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DefDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.DefDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefDGV.EnableHeadersVisualStyles = false;
            this.DefDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.DefDGV.Location = new System.Drawing.Point(0, 0);
            this.DefDGV.Name = "DefDGV";
            this.DefDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DefDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DefDGV.Size = new System.Drawing.Size(734, 417);
            this.DefDGV.TabIndex = 0;
            this.DefDGV.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DefDGV_CellBeginEdit);
            this.DefDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DefDGV_CellValueChanged);
            this.DefDGV.SelectionChanged += new System.EventHandler(this.DefDGV_SelectionChanged);
            // 
            // celltype
            // 
            this.celltype.FillWeight = 35.23328F;
            this.celltype.HeaderText = "Type";
            this.celltype.Name = "celltype";
            this.celltype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // celldisname
            // 
            this.celldisname.FillWeight = 91.60655F;
            this.celldisname.HeaderText = "DisplayName";
            this.celldisname.Name = "celldisname";
            this.celldisname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // celldescription
            // 
            this.celldescription.FillWeight = 173.1602F;
            this.celldescription.HeaderText = "Description";
            this.celldescription.Name = "celldescription";
            // 
            // DefContextMenu
            // 
            this.DefContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DefContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextDeleteFields,
            this.ContextCopyFields,
            this.ContextPasteFields,
            this.ContextCreateField});
            this.DefContextMenu.Name = "FileContextMenu";
            this.DefContextMenu.Size = new System.Drawing.Size(188, 92);
            // 
            // ContextDeleteFields
            // 
            this.ContextDeleteFields.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextDeleteFields.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextDeleteFields.Name = "ContextDeleteFields";
            this.ContextDeleteFields.Size = new System.Drawing.Size(187, 22);
            this.ContextDeleteFields.Text = "Delete Selected Fields";
            this.ContextDeleteFields.ToolTipText = "Delete the currently selected param def fields.";
            this.ContextDeleteFields.Click += new System.EventHandler(this.ContextDeleteFields_Click);
            // 
            // ContextCopyFields
            // 
            this.ContextCopyFields.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextCopyFields.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextCopyFields.Name = "ContextCopyFields";
            this.ContextCopyFields.Size = new System.Drawing.Size(187, 22);
            this.ContextCopyFields.Text = "Copy Selected Fields";
            this.ContextCopyFields.ToolTipText = "Copy the currently selected param def fields.";
            this.ContextCopyFields.Click += new System.EventHandler(this.ContextCopyFields_Click);
            // 
            // ContextPasteFields
            // 
            this.ContextPasteFields.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextPasteFields.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextPasteFields.Name = "ContextPasteFields";
            this.ContextPasteFields.Size = new System.Drawing.Size(187, 22);
            this.ContextPasteFields.Text = "Paste Selected Fields";
            this.ContextPasteFields.ToolTipText = "Paste copied param def fields if any were copied.";
            this.ContextPasteFields.Click += new System.EventHandler(this.ContextPasteFields_Click);
            // 
            // ContextCreateField
            // 
            this.ContextCreateField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContextCreateField.ForeColor = System.Drawing.SystemColors.Control;
            this.ContextCreateField.Name = "ContextCreateField";
            this.ContextCreateField.Size = new System.Drawing.Size(187, 22);
            this.ContextCreateField.Text = "Create Field";
            this.ContextCreateField.ToolTipText = "Create a new param def field.";
            this.ContextCreateField.Click += new System.EventHandler(this.ContextCreateField_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 441);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1215, 25);
            this.MainToolStrip.TabIndex = 1;
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // MenuImportDbp
            // 
            this.MenuImportDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuImportDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuImportDbp.Name = "MenuImportDbp";
            this.MenuImportDbp.Size = new System.Drawing.Size(180, 22);
            this.MenuImportDbp.Text = "Dbp";
            this.MenuImportDbp.ToolTipText = "Import PARAMDBP into PARAMDEF";
            this.MenuImportDbp.Click += new System.EventHandler(this.MenuImportDbp_Click);
            // 
            // MenuImport
            // 
            this.MenuImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuImportDbp});
            this.MenuImport.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuImport.Name = "MenuImport";
            this.MenuImport.Size = new System.Drawing.Size(194, 22);
            this.MenuImport.Text = "Import";
            this.MenuImport.ToolTipText = "Import various kinds of data into defs.";
            // 
            // MenuExportDbp
            // 
            this.MenuExportDbp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuExportDbp.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuExportDbp.Name = "MenuExportDbp";
            this.MenuExportDbp.Size = new System.Drawing.Size(180, 22);
            this.MenuExportDbp.Text = "Dbp";
            this.MenuExportDbp.ToolTipText = "Export loaded defs to dbp.";
            this.MenuExportDbp.Click += new System.EventHandler(this.MenuExportDbp_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1215, 466);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainFormMenuStrip);
            this.Controls.Add(this.MainToolStrip);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MainForm";
            this.Text = "Param Def Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileDGV)).EndInit();
            this.FileContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DefDGV)).EndInit();
            this.DefContextMenu.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAll;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
        private System.Windows.Forms.ToolStripMenuItem MenuCreate;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.DataGridView FileDGV;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.DataGridView DefDGV;
        private System.Windows.Forms.ToolStripLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseAll;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn deftype;
        private System.Windows.Forms.ContextMenuStrip FileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ContextOpen;
        private System.Windows.Forms.ToolStripMenuItem ContextSave;
        private System.Windows.Forms.ToolStripMenuItem ContextSaveAll;
        private System.Windows.Forms.ToolStripMenuItem ContextClose;
        private System.Windows.Forms.ToolStripMenuItem ContextCloseAll;
        private System.Windows.Forms.ToolStripMenuItem ContextCreate;
        private System.Windows.Forms.ToolStripMenuItem MenuCopyDefs;
        private System.Windows.Forms.ToolStripMenuItem MenuPasteDefs;
        private System.Windows.Forms.ToolStripMenuItem ContextCopyDefs;
        private System.Windows.Forms.ToolStripMenuItem ContextPasteDefs;
        private System.Windows.Forms.ToolStripMenuItem MenuCopyFields;
        private System.Windows.Forms.ToolStripMenuItem MenuPasteFields;
        private System.Windows.Forms.ContextMenuStrip DefContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ContextDeleteFields;
        private System.Windows.Forms.ToolStripMenuItem ContextCreateField;
        private System.Windows.Forms.ToolStripMenuItem ContextCopyFields;
        private System.Windows.Forms.ToolStripMenuItem ContextPasteFields;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteFields;
        private System.Windows.Forms.ToolStripMenuItem MenuCreateField;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuExport;
        private System.Windows.Forms.ToolStripMenuItem MenuExportXml;
        private System.Windows.Forms.ToolStripMenuItem MenuExportDef;
        private System.Windows.Forms.DataGridViewTextBoxColumn celltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn celldisname;
        private System.Windows.Forms.DataGridViewTextBoxColumn celldescription;
        private System.Windows.Forms.ToolStripMenuItem MenuExportTxt;
        private System.Windows.Forms.ToolStripMenuItem MenuImport;
        private System.Windows.Forms.ToolStripMenuItem MenuImportDbp;
        private System.Windows.Forms.ToolStripMenuItem MenuExportDbp;
    }
}

