using FluentFiles.FixedLength.Attributes;
using FluentFiles.FixedLength;
using SagePaieImportExport.Converters;

namespace SagePaieImportExport.Attributes
{
    internal class DateFieldAttribute : FixedLengthFieldAttribute
    {
        public DateFieldAttribute(int index, int length = 10) : base(index, length, true)
        {
            Converter = typeof(DateConverter);
            PaddingChar = ' ';
            Padding = Padding.Right;
        }
    }
}
