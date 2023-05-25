using SoulsFormats;
using System.IO;

namespace ParamDefEditor
{
    /// <summary>
    /// A wrapper for defs to store the path they came from easier.
    /// </summary>
    internal class DefWrapper
    {
        /// <summary>
        /// The def itself.
        /// </summary>
        internal PARAMDEF Def { get; set; }

        /// <summary>
        /// The def's param type.
        /// </summary>
        internal string Type
        {
            get => Def.ParamType;
            set
            {
                Def.ParamType = value ?? throw new InvalidDataException("Type of Def cannot be null.");
            }
        }

        /// <summary>
        /// The path the def was loaded from and will be saved to.
        /// </summary>
        internal string Path { get; set; }

        /// <summary>
        /// Used to hold the value of the name of the def file for getting and editing.
        /// </summary>
        private string _Name { get; set; }

        /// <summary>
        /// The name of the def file.
        /// </summary>
        internal string Name
        {
            get => _Name;
            set
            {
                if (value == null)
                    throw new InvalidDataException("Name of Def file cannot be null.");

                string dir = System.IO.Path.GetDirectoryName(Path);
                string newPath = System.IO.Path.Combine(dir, value);
                foreach (string path in Directory.GetFiles(dir))
                    if (File.Exists(newPath))
                        newPath = Path;
                Path = newPath;
                _Name = value;
            }
        }

        /// <summary>
        /// Whether or not the def should be saved or skipped over at save time.
        /// </summary>
        internal bool Modified { get; set; }

        /// <summary>
        /// Create a new def wrapper with default values and no path set.
        /// </summary>
        internal DefWrapper()
        {
            var def = new PARAMDEF();
            Def = def;
            Type = def.ParamType;
            Modified = false;
        }

        /// <summary>
        /// Create a new def wrapper with the chosen def and no path set.
        /// </summary>
        /// <param name="def">The def to place in the wrapper.</param>
        internal DefWrapper(PARAMDEF def)
        {
            Def = def;
            Type = def.ParamType;
            Modified = false;
        }


        /// <summary>
        /// Create a new def wrapper with the chosen def and path.
        /// </summary>
        /// <param name="def">The def to place in the wrapper.</param>
        /// <param name="path">The full file path to the chosen def.</param>
        internal DefWrapper(PARAMDEF def, string path)
        {
            Def = def;
            Type = def.ParamType;
            Path = path;
            _Name = System.IO.Path.GetFileName(path);
            Modified = false;
        }

        /// <summary>
        /// Write the wrapped def easier.
        /// </summary>
        internal void Write()
        {
            Def.Write(Path);
        }

        /// <summary>
        /// Override ToString to hide the fact the def wrapper is being stored in a DataGridViewCell.
        /// </summary>
        /// <returns>The file name of the def.</returns>
        public override string ToString() => Name;
    }
}