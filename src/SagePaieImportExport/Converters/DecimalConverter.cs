using System;
using FluentFiles.Core.Conversion;
using System.Globalization;

namespace SagePaieImportExport.Converters
{
    internal class DecimalConverter : IFieldValueConverter
    {
        static readonly NumberFormatInfo formatFr = CultureInfo.InvariantCulture/*GetCultureInfo("fr-FR")*/.NumberFormat;
        //
        // Summary:
        //     Whether a value of a given type can be converted to a string.
        //
        // Parameters:
        //   from:
        //     The type to convert from.
        //
        // Returns:
        //     Whether a type can be converted to a string.
        public bool CanFormat(Type from)
        {
            return from == typeof(decimal) || from == typeof(decimal?);
        }

        //
        // Summary:
        //     Whether a value of a given type can be converted from a string.
        //
        // Parameters:
        //   to:
        //     The type to convert to.
        //
        // Returns:
        //     Whether a type can be converted to a string.
        public bool CanParse(Type to)
        {
            return to == typeof(decimal) || to == typeof(decimal?);
        }

        //
        // Summary:
        //     Converts a string to an object instance.
        //
        // Parameters:
        //   context:
        //     Provides information about a field parsing operation.
        //
        // Returns:
        //     A parsed value.
        public object Parse(in FieldParsingContext context)
        {
            string source = context.Source.ToString().Trim();
            return Parse(in source, formatFr);
        }

        //
        // Summary:
        //     Converts an object to a string.
        //
        // Parameters:
        //   context:
        //     Provides information about a field serialization operation.
        //
        // Returns:
        //     A formatted value.
        public string Format(in FieldFormattingContext context)
        {
            return Format((decimal?)context.Source, formatFr);
        }

        string IFieldFormatter.Format(in FieldFormattingContext context)
        {
            return Format(in context);
        }

        object IFieldParser.Parse(in FieldParsingContext context)
        {
            return Parse(in context);
        }

        protected string Format(decimal? value, NumberFormatInfo format)
        {
            return value != null ? value.Value.ToString("0.0000", format) : "";
        }

        protected decimal? Parse(in string source, NumberFormatInfo format)
        {
            return string.IsNullOrEmpty(source) ? (decimal?)null : decimal.Parse(source, format);
        }
    }
}
