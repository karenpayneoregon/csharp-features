namespace ConfigurationHelper.Classes
{
    /// <summary>
    /// Properties for setting up a connection string
    /// </summary>
    public class DatabaseSettings
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
        /// true to use production, false to use test environment
        /// </summary>        
        public bool UsingLogging { get; set; }
        /// <summary>
        /// Connection string ready to use.
        /// </summary>
        public string ConnectionString => $"Data Source={DatabaseServer};" +
                                          $"Initial Catalog={Catalog};" +
                                          $"Integrated Security={IntegratedSecurity}";

    }

}
