using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JsonCodeSamples.Classes
{
    /// <summary>
    /// Provides serializing operation methods
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Convert &lt;see cref="TModel"/&gt; to json file
        /// </summary>
        /// <typeparam name="TModel">type to serialize</typeparam>
        /// <param name="list">List of TModel</param>
        /// <param name="fileName">Save to file</param>
        /// <returns><see cref="ValueTuple"/> of bool for success, <see cref="Exception"/> if a runtime exception is thrown</returns>
        public static (bool, Exception) ModelListToJson<TModel>(this List<TModel> list, string fileName)
        {
            JsonConvert.DefaultSettings = NewtonSettings.SettingsDefault;
            
            try
            {
                var json = JsonConvert.SerializeObject(list);

                File.WriteAllText(fileName, json);

                return (true, null);
            }
            catch (Exception e)
            {
                return (false, e);
            }
        }
        /// <summary>
        /// Saves TModel to a file
        /// </summary>
        /// <typeparam name="TModel">type to serialize</typeparam>
        /// <param name="list">List of TModel</param>
        /// <param name="fileName">Save to file</param>
        /// <returns></returns>
        public static (bool, Exception) ModelToJson<TModel>(this TModel list, string fileName)
        {
            JsonConvert.DefaultSettings = NewtonSettings.SettingsDefault;
            
            try
            {
                var json = JsonConvert.SerializeObject(list);

                File.WriteAllText(fileName, json);

                return (true, null);
            }
            catch (Exception e)
            {
                return (false, e);
            }
        }
        /// <summary>
        /// Read file, convert to TModel/>
        /// </summary>
        /// <typeparam name="TModel">type to deserialize</typeparam>
        /// <param name="fileName">Read from file</param>
        /// <returns></returns>
        public static (TModel, Exception) JsonToModel<TModel>(string fileName) where TModel : new()
        {
            try
            {
                return (JsonConvert.DeserializeObject<TModel>(File.ReadAllText(fileName)),null);
            }
            catch (Exception e)
            {
                return (new TModel(), e);
            }
        }
        /// <summary>
        /// List of T from file
        /// </summary>
        /// <typeparam name="T">Type to deserialize</typeparam>
        /// <param name="fileName">Read from file</param>
        /// <returns><see cref="ValueTuple"/> of list and <see cref="Exception"/></returns>
        public static (List<T>, Exception) JsonToListModel<T>(string fileName)
        {
            try
            {
                return (JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(fileName)), null);
            }
            catch (Exception e)
            {
                return (null, e);
            }
            
        }
    }
}