using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerAsyncRead.Classes
{
    /// <summary>
    /// Similar to <see cref="DataTableResults"/> while in this
    /// case the missing property for returning data may be a projection
    /// create via LINQ.
    /// </summary>
    public class SomeEntityResult
    {
        /// <summary>
        /// Set when there is a connection to the server failure
        /// </summary>
        public bool ConnectionFailed { get; set; }
        /// <summary>
        /// General exception message
        /// </summary>
        public string ExceptionMessage { get; set; }
        /// <summary>
        /// General exception if not connection failure
        /// </summary>
        public Exception GeneralException { get; set; }
        /// <summary>
        /// Is there an exception thrown
        /// </summary>
        public bool HasException => ConnectionFailed || GeneralException != null;
    }
}
