using System;

namespace ImgManager
{
    using System.Drawing;
    using System.IO;

    public static class ImageManager
    {
        static string base64String = null;
        public static string ImageToBase64(string jpgFile)
        {
            string path = jpgFile;
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
    }
}
