using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Ranges_examples.Classes
{
    public class JSonHelper
    {
        /// <summary>
        /// Setup to format json
        /// </summary>
        public readonly DataContractJsonSerializerSettings Settings = new DataContractJsonSerializerSettings
        {
            UseSimpleDictionaryFormat = true,
        };

        /// <summary>
        /// Convert json string to T
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="jsonString">Valid json string</param>
        /// <returns>Instance of T</returns>
        public static T ConvertJSonToObject<T>(string jsonString)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            T item = (T)serializer.ReadObject(ms);
            return item;
        }
        /// <summary>
        /// Write T to json file
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="type">Type</param>
        /// <param name="path">File name with optional path</param>
        /// <returns></returns>
        public static bool ConvertJSonToObjectWithFormatting<T>(T type, string path)
        {
            var success = true;

            try
            {
                
                using var stream = File.Open(path, FileMode.Create);

                try
                {
                    
                    using var writer = JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true, true, "  ");

                    var serializer = new DataContractJsonSerializer(typeof(T));
                    serializer.WriteObject(writer, type);
                    writer.Flush();

                }
                catch (Exception)
                {
                    success = false;
                }
            }
            catch (Exception)
            {
                success = false;
            }

            return success;
        }
    }
}