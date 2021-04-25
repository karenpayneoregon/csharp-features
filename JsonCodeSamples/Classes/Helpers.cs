using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JsonCodeSamples.Classes
{
    public static class Helpers
    {
        /// <summary>
        /// Convert <see cref="TModel"/> to json file
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="list"></param>
        /// <param name="fileName"></param>
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