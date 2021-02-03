using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinControls
{
    public interface TEntity
    {
        int Identifier { get;} 
    }

    public class Customer : TEntity
    {
        public int Id { get; set; }
        public int Identifier => Id;
    }
    public class Manager : TEntity
    {
        public int Id { get; set; }
        public int Identifier => Id;
    }
    public class SalesRepresentative 
    {
        public int Id { get; set; }
        public int Identifier => Id;
    }

    public class GenericRepository<T> where T : TEntity
    {
        public async Task<int> AddAsync(T entity)
        {
            return ((TEntity) entity).Identifier;
        }
    }
}
