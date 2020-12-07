using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Models;

namespace TempProject.Context
{
    public partial class StoredProcedures
    {
        private readonly NorthwindContext _context;

        public StoredProcedures(NorthwindContext context)
        {
            _context = context;
        }

        public async Task<int> sp_upgraddiagrams()
        {
            return await _context.Database.ExecuteSqlRawAsync("EXEC [dbo].[sp_upgraddiagrams]");
        }

        public async Task<uspCustomersByCountryIdentifierResult[]> uspCustomersByCountryIdentifier(int? CountryIdentifier)
        {
            var parameterCountryIdentifier = new SqlParameter
            {
                ParameterName = "CountryIdentifier",
                Precision = 10,
                Size = 4,
                SqlDbType = System.Data.SqlDbType.Int,
                Value = CountryIdentifier,
            };

            uspCustomersByCountryIdentifierResult[] result = await _context
                .SqlQuery<uspCustomersByCountryIdentifierResult>("EXEC [dbo].[uspCustomersByCountryIdentifier] @CountryIdentifier  ",
                    parameterCountryIdentifier);

            return result;
        }

        public async Task<List<string>> CustomersByCountryIdentifier(int? CountryIdentifier)
        {
            var customerResults = await uspCustomersByCountryIdentifier(CountryIdentifier);
            return customerResults.Select(cust => cust.FirstName).ToList();

        }

        public async Task<uspGetCustomers1Result[]> uspGetCustomers1()
        {
            var result = await _context.SqlQuery<uspGetCustomers1Result>("EXEC [dbo].[uspGetCustomers1]");

            return result;
        }
    }
}
