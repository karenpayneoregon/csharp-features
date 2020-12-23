namespace ConfigurationHelper.Classes
{
    /// <summary>
    /// Container connection strings to development and production environments.
    /// To add a test environment, add a property below and add a property to match
    /// in appsettings.json this also needs a flag property in place of IsProduction which
    /// would be a string to be converted to an enum and checked against in a DbContext
    /// </summary>
    public class ConnectionStrings
    {
        /// <summary>
        /// Development environment connection string
        /// </summary>
        public string DevelopmentConnection { get; set; }
        /// <summary>
        /// Production environment connection string
        /// </summary>        
        public string ProductionConnection { get; set; }
        /// <summary>
        /// true to use production, false to use test environment
        /// </summary>
        public bool IsProduction { get; set; }
    }
}