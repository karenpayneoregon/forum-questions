using System;
using System.ComponentModel;

namespace PropertyGridConverterExample.Classes
{
    public class StreetAddressConverter : TypeConverter
    {
        // Return true if we need to convert from a string.
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        // Return true if we need to convert into a string.
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
        }

        // Convert from a string.
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                // Split the string separated by commas.
                string txt = (string)(value);
                string[] fields = txt.Split(new[] { ',' });

                try
                {
                    return new StreetAddress() { Street = fields[0], City = fields[1], State = fields[2], Zip = fields[3] };
                }
                catch
                {
                    throw new InvalidCastException($"Cannot convert the string '{value}' into a StreetAddress");
                }
            }
            else
            {
                return base.ConvertFrom(context, culture, value);
            }
        }

        // Convert the StreetAddress to a string.
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            return destinationType == typeof(string) ? value.ToString() : base.ConvertTo(context, culture, value, destinationType);
        }

        // Return true to indicate that the object supports properties.
        public override bool GetPropertiesSupported(ITypeDescriptorContext context) => true;

        // Return a property description collection.
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) => TypeDescriptor.GetProperties(value);
    }
}