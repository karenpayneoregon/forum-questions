using System.ComponentModel;

namespace PropertyGridConverterExample.Classes
{
    [TypeConverter(typeof(StreetAddressConverter))]
    public class StreetAddress
    {
        [Description("The street number, name, apartment number, etc. as in '123 N. Elm Ave Suite 21'")]
        public string Street { get; set; }

        [Description("The mailing address city")]
        public string City { get; set; }

        [Description("The two-letter state abbreviation")]
        public string State { get; set; }

        [Description("The postal ZIP or ZIP+4 code")]
        public string Zip { get; set; }

        // Return as a comma-delimited string.
        public override string ToString() => $"{Street},{City},{State},{Zip}";
    }
}