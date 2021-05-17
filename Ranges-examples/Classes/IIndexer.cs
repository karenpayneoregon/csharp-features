using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges_examples.Classes
{
    /// <summary>
    /// Add Index properties to class
    /// </summary>
    public interface IIndexer
    {
        /// <summary>
        /// Start <see cref="Index"/>
        /// </summary>
        public Index StartIndex { get; set; }
        /// <summary>
        /// End <see cref="Index"/>
        /// </summary>
        [NotMapped]
        public Index EndIndex { get; set; }

    }
}
