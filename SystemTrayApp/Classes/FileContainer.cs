namespace SystemTrayApp.Classes
{
    public class FileContainer
    {
        public bool Processed { get; set; }
        public string Action { get; set; }
        public string Message { get; set; }
        public string EventTime { get; set; }
        public override string ToString()
        {
            return $"{Action},{Message},{EventTime}";
        }
    }
}