using System;
using System.IO;

namespace WorkingWithMsAccessImages.Classes
{
    public static class ConversionModule
    {
        /// <summary>
        /// Saves bytes to a new image file
        /// </summary>
        /// <param name="pImageData"></param>
        /// <param name="pFilePath"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool ConvertBytesToImageFile(byte[] pImageData, string pFilePath)
        {
            try
            {
                var fileStream = new FileStream(pFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                var binaryWriter = new BinaryWriter(fileStream);

                binaryWriter.Write(pImageData);
                binaryWriter.Flush();
                binaryWriter.Close();
                fileStream.Close();
                binaryWriter = null;
                fileStream.Dispose();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        /// <summary>
        /// Return a byte array for a file, in this demo a image file
        /// used in the DataAccess.vb file to add new records to the database
        /// </summary>
        /// <param name="pFileName">Physical file to get bytes from for image operations</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static byte[] FileImageBytes(string pFileName)
        {
            var fileStream = new FileStream(pFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            var imageStream = new StreamReader(fileStream);
            byte[] byteArray = new byte[((int)(fileStream.Length - 1)) + 1];

            fileStream.Read(byteArray, 0, (int)fileStream.Length);

            return byteArray;

        }
    }
}