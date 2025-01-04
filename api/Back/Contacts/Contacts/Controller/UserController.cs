using Contacts.BLogic;
using Contacts.Instance;
using Contacts.Instance.Table;
using Contacts.Instance.User;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controller
{
    [ApiController]
    [Route("user")]
    public class UserController
    {
        private UserB business;

        public UserController()
        {
            this.business = new UserB();
        }
        
        [HttpPost("sign-up")]
        public BResultM<int> SignUp(UserSignUpM model)
        {
            return this.business.SignUpB(model);
        }
        [HttpPost("sign-in")]
        public BResultM<int> SignIn(UserSignInM model)
        {
            return this.business.SignInB(model);
        }

        [HttpGet("Profile")]
        public BResultM<UserProfileM> Profile(int model)
        {
            return this.business.ProfileB(model);
        }

    }
}
