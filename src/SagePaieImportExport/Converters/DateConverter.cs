using System;
using FluentFiles.Core.Conversion;
using System.Globalization;

namespace SagePaieImportExport.Converters
{
    internal class DateConverter : IFieldValueConverter
    {
        public bool CanFormat(Type from) => from == typeof(DateTime) || from == typeof(DateTime?);

        public bool CanParse(Type to) => to == typeof(DateTime) || to == typeof(DateTime?);

        /// <summary>
        /// Converts an object to a string.
        /// </summary>
        /// <param name="context">Provides information about a field serialization operation.</param>
        /// <returns>A formatted value.</returns>
        public string Format(in FieldFormattingContext context)
        {
            var culture = CultureInfo.CurrentCulture;
            if (context.Source is null)
                return "";
            return ((DateTime)context.Source).ToString("dd/MM/yyyy", culture);
        }

        /// <summary>
        /// Converts a string to an object instance.
        /// </summary>
        /// <param name="context">Provides information about a field parsing operation.</param>
        /// <returns>A parsed value.</returns>
        public object Parse(in FieldParsingContext context)
        {
            if (!DateTime.TryParseExact(context.Source.ToString(), "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal, out var dt))
                return null;
            return dt;
        }
    }
}
