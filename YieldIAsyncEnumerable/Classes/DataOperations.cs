using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace YieldIAsyncEnumerable.Classes
{
    public class DataOperations
    {
        private static readonly string _connectionString = 
            @"Data Source=.\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True";

        private static string _selectStatement = 
            "SELECT FirstName + ' ' + LastName As FullName FROM dbo.Contacts ORDER BY LastName;";
        
        public static async IAsyncEnumerable<string> GetAllNames(bool delay)
        {
            
            await using var cn = new SqlConnection(_connectionString);
            await using var cmd = new SqlCommand { Connection = cn, CommandText = _selectStatement };

            await cn.OpenAsync(new CancellationTokenSource(TimeSpan.FromSeconds(GlobalStuff.TimeOutSeconds)).Token);
            await using var reader = await cmd.ExecuteReaderAsync();

            while (reader.Read())
            {
                
                if (delay)
                {
                    await Task.Delay(GlobalStuff.TimeSpan);
                }
                
                yield return reader.GetString(0);
            }

        }
    }
}