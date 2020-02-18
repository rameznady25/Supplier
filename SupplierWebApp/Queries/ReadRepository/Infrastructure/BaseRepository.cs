using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierWebApp.Queries.ReadRepository.Infrastructure
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {


        private string _connectionString = string.Empty;

        public BaseRepository(string constr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(constr) ? constr : throw new ArgumentNullException(nameof(constr));

        }




        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string qr = $"SELECT *  FROM [Supplier].[dbo].[{typeof(T).Name}]"; // Supplier
                var res = connection.QueryAsync<T>(qr);
                return await res;
            }
        }




        public async Task<T> GetByIdAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string qr = $"SELECT *  FROM [Supplier].[dbo].[{typeof(T).Name}] Where Id = @id";
                var result = await connection.QueryAsync<T>(qr, new { id });

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return (T)result.FirstOrDefault();
            }
        }

        public async Task<T> GetWhereAsync(object obj)
        {
            string condition = "";

            if (obj != null)
            {
                condition = "Where ";
                //object dd = new { id = 5 };
                foreach (var prop in obj.GetType().GetProperties())
                {
                    condition += prop.Name + "=" + prop.GetValue(obj, null) + " and ";
                }
                condition = condition.Remove(condition.Length - 4);
            }


            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string qr = $"SELECT *  FROM [Supplier].[dbo].[{typeof(T).Name}] " + condition;
                var result = await connection.QueryAsync<T>(qr);

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return (T)result.FirstOrDefault();
            }



        }


    }

}