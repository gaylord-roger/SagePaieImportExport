using FluentFiles.FixedLength.Attributes;
using FluentFiles.FixedLength;
using SagePaieImportExport.Converters;

namespace SagePaieImportExport.Attributes
{
    internal class IntFieldAttribute : FixedLengthFieldAttribute
    {
        public IntFieldAttribute(int index, int length) : base(index, length, true)
        {
            Converter = typeof(IntConverter);
            PaddingChar = ' ';
            Padding = Padding.Left;
        }
    }
}
