using Newtonsoft.Json;

namespace JsonCodeSamples.Classes
{
    /// <summary>
    /// Setting for serializing with Json.net
    /// </summary>
    public static class NewtonSettings
    {
        /// <summary>
        /// Format indent
        /// Prevent Self referencing loop detected
        /// </summary>
        public static JsonSerializerSettings SettingsIgnoreReferenceLooping() => new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        /// <summary>
        /// Format indent
        /// </summary>
        /// <returns></returns>
        public static JsonSerializerSettings SettingsDefault() => new JsonSerializerSettings { Formatting = Formatting.Indented };
    }
}