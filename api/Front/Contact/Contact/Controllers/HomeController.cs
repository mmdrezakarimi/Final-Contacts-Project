using Microsoft.AspNetCore.Mvc;

namespace Contact.Controllers
{
    [ApiController]
    public class HomeController
    {
        [HttpGet("time")]

      public DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        [HttpGet("sum")]

        public int GetSum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
