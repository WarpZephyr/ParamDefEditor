using SoulsFormats;
using System;

namespace ParamDefEditor
{
    internal class FieldWrapper
    {
        internal PARAMDEF.Field Field { get; set; }

        internal DefType Type
        {
            get => Field.DisplayType;
            set
            {
                Field.DisplayType = value;
            }
        }

        internal string Name
        {
            get => Field.DisplayName;
            set => Field.DisplayName = value ?? throw new NullReferenceException($"Field name may not be null.");
        }

        internal string Description
        {
            get => Field.Description ?? "";
            set => Field.Description = value ?? throw new NullReferenceException($"Field description may not be null.");
        }

        internal FieldWrapper(PARAMDEF.Field field)
        {
            Field = field;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
