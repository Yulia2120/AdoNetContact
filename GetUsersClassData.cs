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
                return db.Query<Users>("sp_Users", new { @id1 = 1 }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static int Insert(Users obj)
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters para = new DynamicParameters();
                para.AddDynamicParams
                    (
                    new
                    {
                        id1 = 2,
                        FirstName = obj.FirstName,
                        SurName = obj.SurName,
                        LastName = obj.LastName,
                        Birthday = obj.Birthday,
                        Phone = obj.Phone,
                        DataAdded = obj.DataAdded
                    });
                return db.Execute("sp_Users", para, commandType: CommandType.StoredProcedure);
            }
        }
        public static int Update(Users obj)
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Execute("sp_Users", new
                {
                    id1 = 3,
                    Id = obj.Id,
                    FirstName = obj.FirstName,
                    SurName = obj.SurName,
                    LastName = obj.LastName,
                    Birthday = obj.Birthday,
                    Phone = obj.Phone,
                    DataAdded = obj.DataAdded
                },
                    commandType: CommandType.StoredProcedure);
            }
        }
            public static int Delete(Users obj)
            {
                using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    return db.Execute("sp_Users", new
                    {
                        id1 = 4,
                        Id = obj.Id
                    },
                        commandType: CommandType.StoredProcedure);
                }



            }
        }
}
