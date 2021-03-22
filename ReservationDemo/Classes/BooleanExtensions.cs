namespace ReservationDemo.Classes
{
    /// <summary>
    /// Bool language extensions
    /// </summary>
    public static class BooleanExtensions
    {
        public static string ToAvailable(this bool value) => value ? "Available" : "Unavailable";
    }
}