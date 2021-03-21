namespace ReservationDemo.Classes
{
    public class SeatTable
    {
        public int Id { get; set; }
        public string Row { get; set; }
        public int Number { get; set; }
        public bool Available { get; set; }
        /// <summary>
        /// For debugging
        /// </summary>
        /// <returns>Id, Row, Number properties</returns>
        public override string ToString() => $"{Id}, {Row}{Number}";

    }
}
