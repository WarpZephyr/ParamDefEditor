using SoulsFormats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamDefEditor
{
    public static class Importer
    {
        public enum ImportType
        {
            Dbp
        }

        public static PARAMDEF Import(string path, ImportType type)
        {
            switch (type)
            {
                case ImportType.Dbp:
                    return PARAMDBP.Read(path).ToDef(Path.GetFileNameWithoutExtension(path));
                default:
                    throw new NotSupportedException($"{nameof(ImportType)} {type} is not supported for the operation: Import");
            }
        }

        /// <summary>
        /// Convert PARAMDBP into PARAMDEF.
        /// </summary>
        /// <param name="dbp">The dbp.</param>
        /// <param name="dbpname">The name of the dbp, to be processed into the def's paramtype.</param>
        /// <returns>A new PARAMDEF.</returns>
        public static PARAMDEF ToDef(this PARAMDBP dbp, string dbpname = null)
        {
            if (dbpname == null)
                dbpname = "DBP_DEF_DEFAULT";
            else
            {
                if (File.Exists(dbpname))
                    dbpname = Path.GetFileNameWithoutExtension(dbpname);
                if (dbpname.Contains("."))
                    dbpname = dbpname.Remove(dbpname.IndexOf("."));
                dbpname = dbpname.ToUpper();

                char[] chars = dbpname.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                    if (!char.IsLetter(chars[i]) && chars[i] != '_')
                        chars[i] = '_';
                dbpname = new string(chars);
            }

            var def = new PARAMDEF
            {
                BigEndian = dbp.BigEndian,
                Compression = dbp.Compression,
                Unicode = false,
                DataVersion = 1,
                FormatVersion = 101,
                ParamType = dbpname,
                Fields = new List<PARAMDEF.Field>(dbp.Fields.Count)
            };

            foreach (var field in dbp.Fields)
            {
                var deffield = new PARAMDEF.Field(def)
                {
                    InternalName = "",
                    Description = "",
                    ArrayLength = 1,
                    BitSize = -1,
                    EditFlags = PARAMDEF.EditFlags.None,
                    SortID = 0,
                    UnkB8 = "",
                    UnkC0 = "",
                    UnkC8 = "",

                    DisplayType = field.DisplayType,
                    InternalType = field.DisplayType.ToString(),
                    DisplayFormat = field.DisplayFormat,
                    DisplayName = field.DisplayName ?? "",
                    Default = field.Default,
                    Minimum = field.Minimum,
                    Maximum = field.Maximum,
                    Increment = field.Increment,
                };
                def.Fields.Add(deffield);
            }

            return def;
        }
    }
}
