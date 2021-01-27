using System.IO;
using System.Linq;

namespace ChangeFileExtensions
{
    public static class FileHelpers
    {
        public static void RenameExtensions(string path, string originalExtensions, string replacementExtension)
        {
            new DirectoryInfo(path).GetFiles($"*.{originalExtensions}")
                .ToList()
                .ForEach(myFile =>
                {
                    var filename = Path.ChangeExtension(myFile.Name, $".{replacementExtension}");
                    var tempName = Path.Combine(path, filename);
                    
                    if (File.Exists(tempName))
                    {
                        File.Delete(tempName);
                    }
                    
                    File.Move(myFile.Name, filename);
                    
                });
        }
    }
}