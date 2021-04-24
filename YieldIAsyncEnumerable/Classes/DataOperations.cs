using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using ConfigurationHelper;


namespace YieldIAsyncEnumerable.Classes
{
    public class DataOperations
    {

        private static string _selectStatement = "SELECT FirstName + ' ' + LastName As FullName FROM dbo.Contacts ORDER BY LastName;";
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="delay">For demonstration purposes else this will happen in a blink of an eye </param>
        /// <returns></returns>
        public static async IAsyncEnumerable<string> GetAllNames(bool delay)
        {
            
            await using var cn = new SqlConnection(Helper.ConnectionString());
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

        public delegate void OnNewPage(int page);
        public static event OnNewPage NewPage;
        /// <summary>
        /// Difference between this method and the one above is the one above
        /// gets all data at once which uses more memory at once while this one
        /// is a smaller footprint as the SQL is paged.
        /// </summary>
        /// <param name="delay"></param>
        /// <returns></returns>
        public static async IAsyncEnumerable<string> GetAllNamesPaged(bool delay)
        {
            var pageIndex = 0;
            const int pageSize = 10;
            var hasMore = false;

            do
            {
                await using var cn = new SqlConnection(Helper.ConnectionString());
                await using var cmd = new SqlCommand { Connection = cn, CommandText = _selectStatement };
                
                cmd.CommandText = 
                    "SELECT FirstName + ' ' + LastName As FullName FROM dbo.Contacts ORDER BY LastName " + 
                    $"OFFSET {pageIndex * pageSize} ROWS FETCH NEXT {pageSize} ROWS ONLY;";

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

                pageIndex++;
                
                NewPage?.Invoke(pageIndex);
                
                hasMore = reader.HasRows;

            } while (hasMore);



        }
    }
}