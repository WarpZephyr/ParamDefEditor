using SoulsFormats;
using System;

namespace ParamDefEditor
{
    internal class FieldWrapper
    {
        internal PARAMDEF.Field Field { get; set; }

        internal PARAMDEF.DefType Type
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
            set
            {
                if (value == null)
                    throw new NullReferenceException($"Field name may not be null.");

                Field.DisplayName = value;
            }
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
