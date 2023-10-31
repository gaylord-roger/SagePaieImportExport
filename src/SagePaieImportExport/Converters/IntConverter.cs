using System;
using FluentFiles.Core.Conversion;
using System.Globalization;

namespace SagePaieImportExport.Converters
{
    internal class IntConverter : IFieldValueConverter
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
            return from == typeof(int) || from == typeof(int?) || from == typeof(byte) || from == typeof(byte?);
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
            return to == typeof(int) || to == typeof(int?) || to == typeof(byte) || to == typeof(byte?);
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

            if (context.TargetType == typeof(int) || context.TargetType == typeof(int?))
            {
                return ParseInt(in source, formatFr);
            }
            else
            if (context.TargetType == typeof(byte) || context.TargetType == typeof(byte?))
            {
                return ParseByte(in source, formatFr);
            }

            throw new NotImplementedException("Type non supporté");
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

            if (context.SourceType == typeof(int) || context.SourceType == typeof(int?))
            {
                return FormatInt((int?)context.Source, formatFr);
            }
            else
            if (context.SourceType == typeof(byte) || context.SourceType == typeof(byte?))
            {
                return FormatByte((byte?)context.Source, formatFr);
            }

            throw new NotImplementedException("Type non supporté");
        }

        string IFieldFormatter.Format(in FieldFormattingContext context)
        {
            return Format(in context);
        }

        object IFieldParser.Parse(in FieldParsingContext context)
        {
            return Parse(in context);
        }

        protected string FormatInt(int? value, NumberFormatInfo format)
        {
            return value != null ? value.Value.ToString(format) : "";
        }

        protected int? ParseInt(in string source, NumberFormatInfo format)
        {
            return string.IsNullOrEmpty(source) ? (int?)null : int.Parse(source, format);
        }

        protected string FormatByte(byte? value, NumberFormatInfo format)
        {
            return value != null ? value.Value.ToString(format) : "";
        }

        protected byte? ParseByte(in string source, NumberFormatInfo format)
        {
            return string.IsNullOrEmpty(source) ? (byte?)null : byte.Parse(source, format);
        }
    }
}
