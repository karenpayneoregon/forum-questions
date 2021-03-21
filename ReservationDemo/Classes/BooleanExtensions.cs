namespace ReservationDemo.Classes
{
    public static class BooleanExtensions
    {
        public static string ToAvailable(this bool value) => value ? "Available" : "Unavailable";
    }
}