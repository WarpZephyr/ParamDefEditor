using SoulsFormats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace ParamDefEditor
{
    public static class Exporter
    {
        public enum ExportType
        {
            Def,
            Xml,
            Txt
        }

        public static bool Export(this PARAMDEF def, ExportType type, string outPath)
        {
            if (def == null)
                return false;

            outPath = GetOutPath(outPath, type);

            switch (type)
            {
                case ExportType.Def:
                    def.Write(outPath);
                    break;
                case ExportType.Xml:
                    foreach (var field in def.Fields)
                        if (field.InternalName == null || field.InternalName == "")
                            field.InternalName = field.DisplayName;
                    def.XmlSerialize(outPath);
                    break;
                case ExportType.Txt:
                    File.WriteAllLines(outPath, def.TxtSerialize());
                    break;
                default:
                    return false;
            }

            return true;
        }

        public static string GetOutPath(string path, ExportType type)
        {
            return $"{Path.GetDirectoryName(path)}\\{Path.GetFileNameWithoutExtension(path)}{GetExtension(type)}";
        }

        public static string GetExtension(ExportType type)
        {
            switch (type)
            {
                case ExportType.Def: return ".def";
                case ExportType.Xml: return ".xml";
                case ExportType.Txt: return ".txt";
                default: throw new NotSupportedException($"{nameof(ExportType)} {type} is not supported for the GetExtension operation.");
            }
        }
    }
}
