using System.Reflection;
using Contacts.Instance.Table;
using Dapper;
using Microsoft.Data.SqlClient;
namespace Contacts.Tools
{
    public class Crud
    {
        private SqlConnection db;

        public Crud()

        {
            string ConnectionString = "Data Source=DESKTOP-8BGVRA2;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            this.db = new(ConnectionString);
        }

     public int Create<T>(T model)
        {
            Type type = typeof(T);

            string table = type.Name.Replace("Table", "");

            PropertyInfo[] properties = type.GetProperties();

            List<string> fields = new();
            List<string> parameters = new();
            string OUTPUT = "";

            foreach (PropertyInfo property in properties)
            {
                if (property.Name.Equals("ID", StringComparison.OrdinalIgnoreCase))
                {
                    continue; 
                }

                fields.Add($"[{property.Name}]");
                parameters.Add($"@{property.Name}");
            }

            string csvFields = string.Join(",", fields);
            string csvParameters = string.Join(",", parameters);

            string sql = $"INSERT INTO [Contact].[dbo].[{table}] ({csvFields}) {OUTPUT} VALUES ({csvParameters})";

            return this.db.ExecuteScalar<int>(sql, model);

        }

     public bool UpdateById<T>(T model)
        {
            Type type = typeof(T);

            string table = type.Name.Replace("Table", "");

            PropertyInfo[] properties = type.GetProperties();

            List<string> equals = new();

            foreach (PropertyInfo property in properties)
            {
                if (property.Name == "id")
                {
                    continue;
                }

                equals.Add($"[{property.Name}]");
            }
            string csvEquals = string.Join(",", equals);

            string sql = $"UPDATE [Contact].[dbo].[{table}] SET {string.Join(",", equals.Select(e => $"{e} = @{e}"))} WHERE Id = @Id";

            return this.db.ExecuteScalar<int>(sql, model)>0;

        }

     public bool DeleteById<T>(int id)
        {
            //anjam nmishe b khatre Foreign Key
            Type type = typeof(T);
            string table = type.Name.Replace("Table", "");
            string sql = $"DELETE FROM [Contact].[dbo].[{table}] WHERE Id = @Id";

            return this.db.Execute(sql, new { Id = id }) > 0;

        }

     public IEnumerable<T> Select<T>() 
        {
            Type type = typeof(T);
            string table = type.Name.Replace("Table","");
            string sql = $"SELECT * FROM [Contact].[dbo].[{table}]";

            return this.db.Query<T>(sql);
        }

     public T GetByID<T>(int id)
        {
            Type type = typeof(T);
            string table = type.Name.Replace("Table", "");
            string sql = $"SELECT * FROM [Contact].[dbo].[{table}] WHER Id = @Id";

            return this.db.QuerySingle<T>(sql, new { Id = id });
        }

    }
}
