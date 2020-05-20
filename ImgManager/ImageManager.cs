using System;

namespace ImgManager
{
    using System.Drawing;
    using System.IO;

    public static class ImageManager
    {
        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }

        public static Image ConvertPicToImage(string filename)
        {
             return Image.FromFile(filename);
        }
    }
}
