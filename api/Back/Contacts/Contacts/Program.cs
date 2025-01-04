using System.Data.Common;
using System.Net.Http.Headers;
using Contacts.BLogic;
using Contacts.Instance;
using Contacts.Instance.Table;
using Contacts.Instance.User;
using Contacts.Tools;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Contacts
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            var app = builder.Build();
            app.UseCors(x =>
            {
                x.AllowAnyHeader();
                x.AllowAnyMethod();
                x.AllowAnyOrigin();
            });

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
