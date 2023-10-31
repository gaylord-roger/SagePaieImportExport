using System;
using FluentFiles.Core.Conversion;

namespace SagePaieImportExport.Converters
{
    internal class BoolConverter : IFieldValueConverter
    {
        public bool CanFormat(Type from) => from == typeof(bool);
        public bool CanParse(Type to) => to == typeof(bool);


        /// <summary>
        /// Converts an object to a string.
        /// </summary>
        /// <param name="context">Provides information about a field serialization operation.</param>
        /// <returns>A formatted value.</returns>
        public string Format(in FieldFormattingContext context)
        {
            return (bool)context.Source == true ? "1" : "0";
        }

        /// <summary>
        /// Converts a string to an object instance.
        /// </summary>
        /// <param name="context">Provides information about a field parsing operation.</param>
        /// <returns>A parsed value.</returns>
        public object Parse(in FieldParsingContext context)
        {
            return context.Source.ToString() == "1";
        }
    }
}
