using FluentFiles.FixedLength.Attributes;
using FluentFiles.FixedLength;
using SagePaieImportExport.Converters;

namespace SagePaieImportExport.Attributes
{
    internal class BoolFieldAttribute : FixedLengthFieldAttribute
    {
        public BoolFieldAttribute(int index) : base(index, 1, true)
        {
            Converter = typeof(BoolConverter);
            PaddingChar = ' ';
            Padding = Padding.Right;
        }
    }
}
