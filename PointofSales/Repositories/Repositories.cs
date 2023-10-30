using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PointofSales.Repositories
{
    public abstract class Repositories
    {
        private readonly string _connectionString;
        public Repositories()
        {
            _connectionString = "Server=(localdb); Database=PointofSale; Integrated Security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
