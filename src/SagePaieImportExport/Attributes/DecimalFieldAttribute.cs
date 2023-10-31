using FluentFiles.FixedLength.Attributes;
using FluentFiles.FixedLength;
using SagePaieImportExport.Converters;

namespace SagePaieImportExport.Attributes
{
    internal class DecimalFieldAttribute : FixedLengthFieldAttribute
    {
        public DecimalFieldAttribute(int index, int length = 12) : base(index, length, true)
        {
            Converter = typeof(DecimalConverter);
            PaddingChar = ' ';
            Padding = Padding.Left;
        }
    }
}
