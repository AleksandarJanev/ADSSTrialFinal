using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace LibraryForTrialFinal.DataAccess
{
    public static class SqlDataAccess
    {
        public static string GetConnectionString(string connectionName = "MVCDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection conn = new SqlConnection(GetConnectionString()))
            {
                return conn.Execute(sql, data);
            }
        }


        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection conn = new SqlConnection(GetConnectionString()))
            {
                return conn.Query<T>(sql).ToList();
            }
        }
    }
}
