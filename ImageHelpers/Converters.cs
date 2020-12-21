using System;
using System.Drawing;
using System.IO;

namespace ImageHelpers
{
    public class Converters
    {
        /// <summary>
        /// Convert from icon to bitmap
        /// </summary>
        /// <param name="icon">Valid icon</param>
        /// <returns>Bitmap</returns>
        public static Bitmap FromIconToBitmap(Icon icon)
        {
            
            var bmp = new Bitmap(icon.Width, icon.Height);
            using var gp = Graphics.FromImage(bmp);
            gp.Clear(Color.Transparent);
            gp.DrawIcon(icon, new Rectangle(0, 0, icon.Width, icon.Height));
            
            return bmp;
            
        }
        /// <summary>
        /// Convert byte array to Icon
        /// </summary>
        /// <param name="bytes">Bytes to form a Icon</param>
        /// <returns>Icon</returns>
        public static Icon BytesToIcon(byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);
            return new Icon(ms);
            
        }
        /// <summary>
        /// Read file contents and convert to BitMap
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Bitmap FromBytesToBitMap(string fileName)
        {
            var bytes = File.ReadAllBytes(fileName);
            var icon = BytesToIcon(bytes);

            return FromIconToBitmap(icon);
        }
    }


}
