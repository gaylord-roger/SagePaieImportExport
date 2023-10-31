using System;
using FluentFiles.Core.Conversion;
using System.Globalization;

namespace SagePaieImportExport.Converters
{
    internal class EnumConverter : IFieldValueConverter
    {
        public bool CanFormat(Type from) => true;

        public bool CanParse(Type to) => true;

        protected string Format(int value, NumberFormatInfo format) => value.ToString("G", format);

        /// <summary>
        /// Converts an object to a string.
        /// </summary>
        /// <param name="context">Provides information about a field serialization operation.</param>
        /// <returns>A formatted value.</returns>
        public string Format(in FieldFormattingContext context)
        {
            var culture = CultureInfo.CurrentCulture;
            var numberFormat = (NumberFormatInfo)culture.GetFormat(typeof(NumberFormatInfo));
            return Format((int)context.Source, numberFormat);
        }

        /// <summary>
        /// Converts a string to an object instance.
        /// </summary>
        /// <param name="context">Provides information about a field parsing operation.</param>
        /// <returns>A parsed value.</returns>
        public object Parse(in FieldParsingContext context)
        {
            try
            {
                return Enum.Parse(context.TargetType, context.Source.ToString());
            }
            catch
            {
                return null;
                //return Activator.CreateInstance(context.TargetType);
            }
        }
    }
}
