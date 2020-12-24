using System.Drawing;
using System.IO;

namespace UtilityLibrary
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Requires NuGet package
    /// https://www.nuget.org/packages/System.Drawing.Common
    /// </remarks>
    public class ImageHelpers
    {
        // for image column
        public static Image ByteArrayToImage1(byte[] contents)
        {
            using var ms = new MemoryStream(contents);
            return Image.FromStream(ms);
        }
        // for varbinary(max)
        public static Image ByteArrayToImage(byte[] contents)
        {
            var converter = new ImageConverter();
            var image = (Image)converter.ConvertFrom(contents);

            return image;
        }
    }
}
