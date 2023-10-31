using FluentFiles.FixedLength.Attributes;
using FluentFiles.FixedLength;
using SagePaieImportExport.Converters;

namespace SagePaieImportExport.Attributes
{
    internal class EnumFieldAttribute : FixedLengthFieldAttribute
    {
        public EnumFieldAttribute(int index, int length = 1) : base(index, length, true)
        {
            Converter = typeof(EnumConverter);
            PaddingChar = ' ';
            Padding = Padding.Left;
        }
    }
}
