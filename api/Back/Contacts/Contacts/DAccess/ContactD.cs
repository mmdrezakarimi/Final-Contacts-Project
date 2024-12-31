using Microsoft.Data.SqlClient;
using Dapper;
using Contacts.Tools;
using Contacts.Instance;
using Contacts.Instance.Table;

namespace Contacts.DAccess
{
    public class ContactD
    {
        private Crud crud;
        private SqlConnection db;

        public ContactD()
        {
            string ConnectionString = "Data Source=DESKTOP-8BGVRA2;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            this.db = new(ConnectionString);
            this.crud = new Crud();

        }
        public IEnumerable<PhoneTypeTable> GetPhoneTypes()
        {
            return this.crud.Select<PhoneTypeTable>();

        }

    }
}
