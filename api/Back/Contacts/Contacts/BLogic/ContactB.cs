using Contacts.Instance;
using Contacts.Instance.Table;
using Contacts.DAccess;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Contacts.BLogic
{
    public class ContactB
    {
        private ContactD data;
        public ContactB()
        {
            this.data = new ContactD();
        }
        public BResultM<IEnumerable<PhoneTypeTable>> GetPhoneTypes()
        {
            BResultM<IEnumerable<PhoneTypeTable>> result = new();
            result.Success = true;
            result.Data = this.data.GetPhoneTypes();
            return result;
        }
    }
}
