using System;
using System.IO;

namespace WorkingWithMsAccessImages.Classes
{
    public static class ConversionHelpers
    {
        /// <summary>
        /// Saves bytes to a new image file
        /// </summary>
        /// <param name="imageData"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool ConvertBytesToImageFile(byte[] imageData, string filePath)
        {
            try
            {
                var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                var binaryWriter = new BinaryWriter(fileStream);

                binaryWriter.Write(imageData);
                binaryWriter.Flush();
                binaryWriter.Close();
                fileStream.Close();
                binaryWriter = null;
                fileStream.Dispose();

                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }
        public static byte[] FileImageBytes(string fileName)
        {
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            var imageStream = new StreamReader(fileStream);
            byte[] byteArray = new byte[((int)(fileStream.Length - 1)) + 1];

            fileStream.Read(byteArray, 0, (int)fileStream.Length);

            return byteArray;

        }
    }
}