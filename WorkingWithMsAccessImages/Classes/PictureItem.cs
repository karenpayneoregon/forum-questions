namespace WorkingWithMsAccessImages.Classes
{
    public class PictureItem
    {
        public int Identifier { get; set; }
        public byte[] ImageBytes { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
