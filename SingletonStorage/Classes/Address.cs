namespace SingletonStorage.Classes
{
    public class Address
    {
        public int AddressIdentifier { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        // Return as a comma-delimited string.
        public override string ToString() => $"{Street},{City},{State},{Zip}";
    }
}
