using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using Dapper.Contrib.Extensions;

namespace AdoNetContact
{
    public static class GetUsersClassData
    {
        public static IList<Users> GetUsers()
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Users>("sp_Users", commandType:CommandType.StoredProcedure).ToList();
            }
        }


    }
}
