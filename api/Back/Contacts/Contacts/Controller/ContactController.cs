using Contacts.BLogic;
using Contacts.Instance;
using Contacts.Instance.Table;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controller
{
    [ApiController]
    [Route("Contact")]
    public class ContactController
    {
        private ContactB bussines;
        public ContactController()
        {
            this.bussines = new ContactB();
        }
        [HttpGet("phonetype")]
        public BResultM<IEnumerable<PhoneTypeTable>> GetPhoneTypes()
        {
            return bussines.GetPhoneTypes();
        }
    }
}
