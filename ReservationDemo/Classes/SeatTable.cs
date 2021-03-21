namespace ReservationDemo.Classes
{
    public class SeatTable
    {
        /// <summary>
        /// Primary key to database table
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Seat row to combine with Number property
        /// </summary>
        public string Row { get; set; }
        /// <summary>
        /// Number on row to be combined when displaying with Row property
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Is this seat available
        /// </summary>
        public bool Available { get; set; }
        /// <summary>
        /// For debugging
        /// </summary>
        /// <returns>Id, Row, Number properties</returns>
        public override string ToString() => $"{Id}, {Row}{Number}";

    }
}
