using System.Windows.Forms;
using ImageHelpers;

namespace ImageConverterSample.LanguageExtensions
{
    /// <summary>
    /// Load icon from file to PictureBox
    /// </summary>
    public static class PictureBoxExtensions
    {
        public static void LoadIconFromFile(this PictureBox pictureBox, string fileName)
        {
            pictureBox.Image = Converters.FromBytesToBitMap(fileName);
        }
    }
}