using System.Windows.Forms;

namespace ExtenderSample
{
    public static class Extensions
    {
        public static int Identifier(this TextBox sender)
        {
            if (sender.Tag is null)
            {
                return -1;
            }
            else
            {
                return int.TryParse(sender.Tag.ToString(), out var value) ? value : -1;
            }
        }

        public static bool HasIdentifier(this TextBox sender) => 
            sender.Tag is { } && int.TryParse(sender.Tag.ToString(), out _);
    }
}
