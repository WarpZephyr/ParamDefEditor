using SoulsFormats;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Xml;

namespace ParamDefEditor
{
    /// <summary>
    /// A txt serializer for paramdef to more easily mass-edit it.
    /// </summary>
    public static class TxtSerializer
    {
        /// <summary>
        /// Serialize paramdef to txt.
        /// </summary>
        /// <param name="def">The def to serialize.</param>
        /// <returns>A string array of every serialized line.</returns>
        public static string[] TxtSerialize(this PARAMDEF def)
        {
            int count = def.Fields.Count;

            List<string> lines = new List<string>();
            lines.Add("[Def]");
            lines.Add($"Unicode: {def.Unicode}");
            lines.Add($"BigEndian: {def.BigEndian}");
            lines.Add($"Compression: {def.Compression}");
            lines.Add($"FormatVersion: {def.FormatVersion}");
            lines.Add($"DataVersion: {def.DataVersion}");
            lines.Add($"ParamType: {def.ParamType}");
            lines.Add($"FieldCount: {count}");
            lines.Add("\n[DisplayName]");
            foreach (var field in def.Fields)
                lines.Add(field.DisplayName ?? "null");
            lines.Add("\n[InternalName]");
            foreach (var field in def.Fields)
                lines.Add(field.InternalName ?? "null");
            lines.Add("\n[DisplayType]");
            foreach (var field in def.Fields)
                lines.Add(field.DisplayType.ToString());
            lines.Add("\n[InternalType]");
            foreach (var field in def.Fields)
                lines.Add(field.InternalType ?? field.DisplayType.ToString());
            lines.Add("\n[DisplayFormat]");
            foreach (var field in def.Fields)
                lines.Add(field.DisplayFormat == "" ? "null" : ParamUtil.GetDefaultFormat(field.DisplayType));
            lines.Add("\n[Description]");
            foreach (var field in def.Fields)
                lines.Add(field.Description ?? "null");
            lines.Add("\n[ArrayLength]");
            foreach (var field in def.Fields)
                lines.Add($"{field.ArrayLength}" ?? "null");
            lines.Add("\n[BitSize]");
            foreach (var field in def.Fields)
                lines.Add($"{field.BitSize}" ?? "-1");
            lines.Add("\n[Default]");
            foreach (var field in def.Fields)
                lines.Add(VariableValueToString(def, field.DisplayType, field.Default));
            lines.Add("\n[Minimum]");
            foreach (var field in def.Fields)
                lines.Add(VariableValueToString(def, field.DisplayType, field.Minimum));
            lines.Add("\n[Maximum]");
            foreach (var field in def.Fields)
                lines.Add(VariableValueToString(def, field.DisplayType, field.Maximum));
            lines.Add("\n[Increment]");
            foreach (var field in def.Fields)
                lines.Add(VariableValueToString(def, field.DisplayType, field.Increment));
            lines.Add("\n[EditFlags]");
            foreach (var field in def.Fields)
                lines.Add(field.EditFlags.ToString() ?? "None");
            lines.Add("\n[SortID]");
            foreach (var field in def.Fields)
                lines.Add($"{field.SortID}" ?? "null");
            lines.Add("\n[UnkB8]");
            foreach (var field in def.Fields)
                lines.Add(field.UnkB8 ?? "null");
            lines.Add("\n[UnkC0]");
            foreach (var field in def.Fields)
                lines.Add(field.UnkC0 ?? "null");
            lines.Add("\n[UnkC8]");
            foreach (var field in def.Fields)
                lines.Add(field.UnkC8 ?? "null");
            return lines.ToArray();
        }

        /// <summary>
        /// Deserialize a serialized string array of paramdef lines.
        /// </summary>
        /// <param name="lines">A collection of strings that can be accessed via index.</param>
        /// <returns>A new PARAMDEF.</returns>
        /// <exception cref="InvalidDataException">Something was not right with the data.</exception>
        public static PARAMDEF TxtDeserialize(IList<string> lines)
        {
            int index = 0;

            var def = new PARAMDEF();
            string propertyname = lines[index];
            if (propertyname != "[Def]")
                throw new InvalidDataException($"Line {index} should have been \"[Def]\" but was \"{propertyname}\" instead.");
            index++;

            def.Unicode = bool.Parse(lines[index].Substring(lines[index].IndexOf(":") + 2)); index++;
            def.BigEndian = bool.Parse(lines[index].Substring(lines[index].IndexOf(":") + 2)); index++;
            def.Compression = (DCX.Type)Enum.Parse(typeof(DCX.Type), lines[index].Substring(lines[index].IndexOf(":") + 2)); index++;
            def.FormatVersion = short.Parse(lines[index].Substring(lines[index].IndexOf(":") + 2)); index++;
            def.DataVersion = short.Parse(lines[index].Substring(lines[index].IndexOf(":") + 2)); index++;
            def.ParamType = lines[index].Substring(lines[index].IndexOf(":") + 2); index++;

            int count = int.Parse(lines[index].Substring(lines[index].IndexOf(":") + 2)); index++; index++;
            def.Fields = new List<PARAMDEF.Field>(count);
            for (int i = 0; i < count; i++)
                def.Fields.Add(new PARAMDEF.Field(def));

            propertyname = lines[index];
            if (propertyname != "[DisplayName]")
                throw new InvalidDataException($"Line {index} should have been \"[DisplayName]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].DisplayName = lines[index];
                else
                    def.Fields[i].DisplayName = "";
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[InternalName]")
                throw new InvalidDataException($"Line {index} should have been \"[InternalName]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].InternalName = lines[index];
                else
                    def.Fields[i].InternalName = "";
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[DisplayType]")
                throw new InvalidDataException($"Line {index} should have been \"[DisplayType]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].DisplayType = (DefType)Enum.Parse(typeof(DefType), lines[index]);
                else
                    throw new InvalidDataException($"DisplayType must not be null. Stopped on line: {i}");
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[InternalType]")
                throw new InvalidDataException($"Line {index} should have been \"[InternalType]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].InternalType = lines[index];
                else
                    def.Fields[i].InternalType = def.Fields[i].DisplayType.ToString();
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[DisplayFormat]")
                throw new InvalidDataException($"Line {index} should have been \"[DisplayFormat]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].DisplayFormat = lines[index];
                else if (ParamUtil.IsArrayType(def.Fields[i].DisplayType))
                    def.Fields[i].DisplayFormat = "";
                else
                    def.Fields[i].DisplayFormat = ParamUtil.GetDefaultFormat(def.Fields[i].DisplayType);
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[Description]")
                throw new InvalidDataException($"Line {index} should have been \"[Description]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].Description = lines[index];
                else
                    def.Fields[i].Description = "";
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[ArrayLength]")
                throw new InvalidDataException($"Line {index} should have been \"[ArrayLength]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].ArrayLength = int.Parse(lines[index]);
                else
                    def.Fields[i].ArrayLength = 1;
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[BitSize]")
                throw new InvalidDataException($"Line {index} should have been \"[BitSize]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].BitSize = int.Parse(lines[index]);
                else if (!ParamUtil.IsBitType(def.Fields[i].DisplayType))
                    def.Fields[i].BitSize = -1;
                else
                    throw new InvalidDataException($"{nameof(DefType)} {def.Fields[i].DisplayType} is a BitType and cannot have a null BitSize.");
                if (def.Fields[i].BitSize < -1)
                    throw new InvalidDataException($"BitSize must not be below -1.");
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[Default]")
                throw new InvalidDataException($"Line {index} should have been \"[Default]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].Default = ParamUtil.ConvertValue(def.Fields[i].DisplayType, lines[index], def.Fields[i].BitSize, def.Fields[i].ArrayLength);
                else
                    def.Fields[i].Default = ParamUtil.GetDefaultDefault(def, def.Fields[i].DisplayType);
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[Minimum]")
                throw new InvalidDataException($"Line {index} should have been \"[Minimum]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].Minimum = ParamUtil.ConvertValue(def.Fields[i].DisplayType, lines[index], def.Fields[i].BitSize, def.Fields[i].ArrayLength);
                else
                    def.Fields[i].Minimum = ParamUtil.GetDefaultMinimum(def, def.Fields[i].DisplayType);
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[Maximum]")
                throw new InvalidDataException($"Line {index} should have been \"[Maximum]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].Maximum = ParamUtil.ConvertValue(def.Fields[i].DisplayType, lines[index], def.Fields[i].BitSize, def.Fields[i].ArrayLength);
                else
                    def.Fields[i].Maximum = ParamUtil.GetDefaultMaximum(def, def.Fields[i].DisplayType);
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[Increment]")
                throw new InvalidDataException($"Line {index} should have been \"[Increment]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].Increment = ParamUtil.ConvertValue(def.Fields[i].DisplayType, lines[index], def.Fields[i].BitSize, def.Fields[i].ArrayLength);
                else
                    def.Fields[i].Increment = ParamUtil.GetDefaultIncrement(def, def.Fields[i].DisplayType);
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[EditFlags]")
                throw new InvalidDataException($"Line {index} should have been \"[EditFlags]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].EditFlags = (PARAMDEF.EditFlags)Enum.Parse(typeof(PARAMDEF.EditFlags), lines[index]);
                else
                    def.Fields[i].EditFlags = ParamUtil.GetDefaultEditFlags(def.Fields[i].DisplayType);
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[SortID]")
                throw new InvalidDataException($"Line {index} should have been \"[SortID]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[i] != "null" && lines[index] != "")
                    def.Fields[i].SortID = int.Parse(lines[index]);
                else
                    def.Fields[i].SortID = 0;
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[UnkB8]")
                throw new InvalidDataException($"Line {index} should have been \"[UnkB8]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].UnkB8 = lines[index];
                else
                    def.Fields[i].UnkB8 = "";
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[UnkC0]")
                throw new InvalidDataException($"Line {index} should have been \"[UnkC0]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].UnkC0 = lines[index];
                else
                    def.Fields[i].UnkC0 = "";
                index++;
            }
            while (lines[index] == "")
                index++;

            propertyname = lines[index];
            if (propertyname != "[UnkC8]")
                throw new InvalidDataException($"Line {index} should have been \"[UnkC8]\" but was \"{propertyname}\" instead.");
            index++;
            for (int i = 0; i < count; i++)
            {
                if (lines[index] != "null" && lines[index] != "")
                    def.Fields[i].UnkC8 = lines[index];
                else
                    def.Fields[i].UnkC8 = "";
                index++;
            }

            return def;
        }

        private static string VariableValueToString(PARAMDEF def, DefType type, object value)
        {
            if (def.VariableEditorValueTypes)
            {
                switch (type)
                {
                    case DefType.s8:
                    case DefType.u8:
                    case DefType.s16:
                    case DefType.u16:
                    case DefType.s32:
                    case DefType.u32:
                    case DefType.b32:
                        return Convert.ToInt32(value).ToString();
                    case DefType.f32:
                    case DefType.angle32:
                        return Convert.ToSingle(value).ToString();
                    case DefType.f64:
                        return Convert.ToDouble(value).ToString();
                    case DefType.dummy8:
                    case DefType.fixstr:
                    case DefType.fixstrW:
                        return "null";
                    default:
                        throw new NotImplementedException($"Missing variable tostring for type: {type}");
                }
            }
            else
            {
                return Convert.ToSingle(value).ToString("R", CultureInfo.InvariantCulture);
            }
        }
    }
}
