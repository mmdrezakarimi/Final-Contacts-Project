using Contacts.Instance.Table;
using Contacts.Tools;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Contacts.DAccess
{
    public class UserD
    {
        private Crud crud;
        private SqlConnection db;

        public UserD()
        {
            string ConnectionString = "Data Source=DESKTOP-8BGVRA2;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            this.db = new(ConnectionString);
            this.crud = new Crud();

        }
        public int Insert(UserTable table)
        {
            return this.crud.Create(table);
        }


        public int GetUserID(string username, byte[] password)
        {
            string sql = @"SELECT Id FROM [Contact].[dbo].[User] WhERE Username = @Username AND Password = @Password";

            int id = db.ExecuteScalar<int>(sql, new { Username = username, Password = password });
            

            return id;
        }
        public UserTable GetUserDetails(int id)
        {
            string sql = @"SELECT Username , FullName , Avatar FROM [Contact].[dbo].[User] WhERE Id=@Id";

            UserTable info = db.QuerySingle<UserTable>(sql, new { Id = id });

            return info;
        }

    }
}
