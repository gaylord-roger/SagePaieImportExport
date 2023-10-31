using FluentFiles.FixedLength.Attributes;
using FluentFiles.FixedLength;

namespace SagePaieImportExport.Attributes
{
    internal class StringFieldAttribute : FixedLengthFieldAttribute
    {
        public StringFieldAttribute(int index, int length) : base(index, length, true)
        {
            PaddingChar = ' ';
            Padding = Padding.Right;
        }
    }
}
