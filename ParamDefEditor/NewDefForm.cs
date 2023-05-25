using SoulsFormats;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Utilities;

namespace ParamDefEditor
{
    public partial class NewDefForm : Form
    {
        /// <summary>
        /// The new def being created.
        /// </summary>
        internal DefWrapper Def;

        /// <summary>
        /// Whether or not the def was created successfully.
        /// </summary>
        internal bool DefCreated;

        public NewDefForm()
        {
            InitializeComponent();
        }

        private void NewDefForm_Load(object sender, EventArgs e)
        {
            Def = new DefWrapper();
            VersionCombobox.SelectedIndex = 0;
            EncodingCombobox.SelectedIndex = 0;
        }

        private void VersionHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Def Format versions:\n" +
                            "101: Enchanted Arms, Chromehounds, Armored Core 4/For Answer/V/Verdict Day, Shadow Assault: Tenchu\n" +
                            "102: Demon's Souls\n" +
                            "103: Ninja Blade, Another Century's Episode: R\n" +
                            "104: Dark Souls, Steel Battalion: Heavy Armor\n" +
                            "106: Elden Ring (deprecated ObjectParam)\n" +
                            "201: Bloodborne\n" +
                            "202: Dark Souls 3\n" +
                            "203: Elden Ring");
        }

        private void EncodingHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encodings:\n" +
                            "Shift-JIS: Japanese, single byte per character.\n" +
                            "UTF-16: Two bytes per character.\n");
        }

        private void TypeHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The type of the param that uses this def, used to match them up.\n" +
                            "Example: AI_STANDARD_INFO_BANK");
        }

        private void DataVersionHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indicates a revision of the row data structure.");
        }


        private void FieldCountHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How many fields to create in the def.");
        }

        private void BigEndianHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The byte order of the def, check if the def is for PS3 and/or Xbox 360, leave unchecked otherwise.");
        }

        private void PathBrowseButton_Click(object sender, EventArgs e)
        {
            string path = PathUtil.GetSavePath("C:\\Users", "Select a location to save this new def in.");
            if (path == null)
                return;
            PathTextBox.Text = path;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (VersionCombobox.Text == string.Empty)
            {
                MessageBox.Show("Version dropdown must have a selection.");
                return;
            }

            short version;
            try
            {
                version = Convert.ToInt16(VersionCombobox.Text);
            }
            catch
            {
                MessageBox.Show("Version could not be converted to a number and is invalid.");
                return;
            } 

            if (EncodingCombobox.Text == string.Empty)
            {
                MessageBox.Show("Encoding dropdown must have a selection.");
                return;
            }

            if (TypeTextBox.Text == string.Empty)
            {
                MessageBox.Show("The ParamType box must not be empty.");
                return;
            }

            if (version < 106 && TypeTextBox.Text.Length > 32)
            {
                MessageBox.Show("Only versions 106 and above support more than 32 characters in ParamType.");
                return;
            }

            if (TypeTextBox.Text.StartsWith("_") || TypeTextBox.Text.EndsWith("_"))
            {
                MessageBox.Show("ParamType must not start or end with an underscore.");
                return;
            }

            foreach (char c in TypeTextBox.Text)
            {
                if (!char.IsUpper(c) && c != '_')
                {
                    MessageBox.Show("ParamType can only contain uppercase letters and underscores in between.");
                    return;
                }
            }

            if (PathTextBox.Text == string.Empty)
            {
                MessageBox.Show("There must be a save path to save the def to.");
                return;
            }

            bool unicode = EncodingCombobox.Text == "UTF-16";
            bool bigendian = BigEndianCheckBox.Checked;
            string type = TypeTextBox.Text;
            short dataVersion;
            try
            {
                dataVersion = Convert.ToInt16(DataVersionInput.Value);
            }
            catch
            {
                MessageBox.Show("Data Version could not be converted and is invalid.");
                return;
            }

            Def.Def.BigEndian = bigendian;
            Def.Def.Unicode = unicode;
            Def.Def.ParamType = type;
            Def.Def.DataVersion = dataVersion;
            Def.Def.FormatVersion = version;
            Def.Path = PathTextBox.Text;
            Def.Name = Path.GetFileName(PathTextBox.Text);
            for (int i = 0; i < FieldCountInput.Value; i++)
                Def.Def.Fields.Add(new PARAMDEF.Field());

            Def.Write();
            DefCreated = true;
            Close();
        }

        private void TypeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            bool invalidKey = c != '_' && !char.IsLetter(c) && c != (char)Keys.Back && !((ModifierKeys & Keys.Control) == Keys.Control);
            bool startingUnderscore = TypeTextBox.Text == string.Empty && c == '_';
            bool invalidLength = Convert.ToInt16(VersionCombobox.Text) < 106 && TypeTextBox.Text.Length > 32;

            if (invalidKey
             || startingUnderscore
             || invalidLength)
                e.Handled = true;
        }

        private void NewDefForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DefCreated)
                if (!FormUtil.ShowQuestionDialog("Are you sure you wish to close without creating the def?", "Close"))
                    e.Cancel = true;
        }
    }
}