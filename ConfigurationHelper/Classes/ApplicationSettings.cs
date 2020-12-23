namespace ConfigurationHelper.Classes
{
    public class ApplicationSettings
    {
        /// <summary>
        /// Database server to work with
        /// </summary>
        public string DatabaseServer { get; set; }
        /// <summary>
        /// Initial catalog to data
        /// </summary>
        public string Catalog { get; set; }
        /// <summary>
        /// true for server authentication, false requires user name and password
        /// </summary>
        public bool IntegratedSecurity { get; set; }
        /// <summary>
        /// Indicates whether EF Core logging is enabled
        /// </summary>
        public bool UsingLogging { get; set; }
    }

}
