using Dapper;
using SupplierWebApp.Models;
using SupplierWebApp.Queries.Contracts;
using SupplierWebApp.Queries.ReadRepository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
namespace SupplierWebApp.Queries.ReadRepository
{
    public class AreaQueries : BaseRepository<Area>, IAreaQueries
    {

        private string _connectionString = string.Empty;

        public AreaQueries(string constr) : base(constr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(constr) ? constr : throw new ArgumentNullException(nameof(constr));

        }

        public new async Task<Area> GetByIdAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string qr = $"SELECT *  FROM [Supplier].[dbo].[{typeof(Area).Name}] Where AreaCod = @id";
                var result = await connection.QueryAsync<Area>(qr, new { id });

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return (Area)result.FirstOrDefault();
            }
        }


        public new async Task<int> Update(Area value)
        {
            var columns = GetColumns();
            var stringOfColumns = string.Join(", ", columns.Select(e => $"{e} = @{e}"));
            var query = $"update {typeof(Area).Name} set {stringOfColumns} where AreaCod = @AreaCod";

            using (var connection = new SqlConnection(_connectionString))
            {

                return await connection.ExecuteAsync(query, value);
            }

        }

        public async new Task<int> Delete(int id)
        {
            var query = $"delete from  {typeof(Area).Name}  where AreaCod = @AreaCod";

            using (var connection = new SqlConnection(_connectionString))
            {

                return await connection.ExecuteAsync(query,new {AreaCod =id });
            }
        }



    }
}

