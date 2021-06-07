using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FileLibrary
{
    /// <summary>
    /// Several choices for unique file names, pick one remove the others.
    /// </summary>
    public class Operations
    {

        #region Two methods produce non Legible names
        public static string UniqueFileNameByTicks => $@"{DateTime.Now.Ticks}.txt";
        public static string GenerateFileNameByDateAndGuid() => $"{DateTime.Now:yyyyMMddHHmmssfff}_{Guid.NewGuid():N}.txt";
        #endregion


        #region Legible Name
        private static readonly string _pattern = " _{0}";
        private static string _baseFileName => "Recoveredfile";
        /// <summary>
        /// Wrapper for <seealso cref="NextAvailableFilename"/> to obtain next available
        /// file name in a specific folder
        /// </summary>
        /// <returns>Unique ordered file name</returns>
        /// <remarks>
        /// Path is set to main assembly location with a base name of Import.txt
        /// </remarks>
        public static string NextFileName() => 
            NextAvailableFilename(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{_baseFileName}.txt"));

        /// <summary>
        /// Wrapper for <see cref="GetNextFilename"/>
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string NextAvailableFilename(string path)
        {

            if (!File.Exists(path) && Path.GetFileName(path).All(char.IsLetter))
            {
                return path;
            }
            
            return Path.HasExtension(path) ?
                GetNextFilename(path.Insert(path.LastIndexOf(Path.GetExtension(path), 
                    StringComparison.Ordinal), _pattern)) :
                GetNextFilename(path + _pattern);
            
        }
        /// <summary>
        /// Work horse for <seealso cref="NextFileName"/>
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private static string GetNextFilename(string pattern)
        {
            string tmp = string.Format(pattern, 1);

            if (tmp == pattern)
            {
                throw new ArgumentException("The pattern must include an index place-holder", nameof(pattern));
            }

            if (!File.Exists(tmp))
            {
                return tmp;
            }

            int min = 1, max = 2;

            while (File.Exists(string.Format(pattern, max)))
            {
                min = max;
                max *= 2;
            }

            while (max != min + 1)
            {
                int pivot = (max + min) / 2;
                
                if (File.Exists(string.Format(pattern, pivot)))
                {
                    min = pivot;
                }
                else
                {
                    max = pivot;
                }
            }

            return string.Format(pattern, max);
        }
        #endregion

        /// <summary>
        /// Strip characters from string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetNumbers(string input) => 
            new string(input.Where(char.IsDigit).ToArray());
        
        /// <summary>
        /// Recovery files
        /// </summary>
        private static string[] RecoveryFiles => 
            Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, 
                $"{_baseFileName}*.txt");
        
        /// <summary>
        /// Get last recovery file by int value
        /// </summary>
        /// <returns></returns>
        public static string GetLast()
        {
            var result = RecoveryFiles
                .Select(x => new {Name = x, Number = Convert.ToInt32(GetNumbers(Path.GetFileName(x))) })
                .OrderByDescending(x => x.Number).FirstOrDefault();

            return result?.Name;
        }

        /// <summary>
        /// Determine if there are any recovery files
        /// </summary>
        /// <returns></returns>
        public static bool HasAnyRecoveryFiles() =>
            RecoveryFiles.Length >0;

        /// <summary>
        /// Remove all recovery files
        /// </summary>
        public static void RemoveAllRecoveryFiles()
        {
            if (HasAnyRecoveryFiles())
            {
                foreach (var file in RecoveryFiles)
                {
                    File.Delete(file);
                }
            }
        }
    }
}
