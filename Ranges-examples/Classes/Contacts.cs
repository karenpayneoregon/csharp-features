using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges_examples.Classes
{
    public class Contacts : IIndexer
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        [NotMapped]
        public Index StartIndex { get; set; }
        [NotMapped]
        public Index EndIndex { get; set; }
        public override string ToString() => $"{ContactId, 3} {FirstName} {LastName}";
    }
}
