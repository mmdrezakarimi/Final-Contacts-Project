using System.Data.Common;
using System.Net.Http.Headers;
using Contacts.BLogic;
using Contacts.Instance;
using Contacts.Instance.Table;
using Contacts.Instance.User;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Contacts
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //string imgdata = Convert.ToBase64String(File.ReadAllBytes("C:\\Users\\ZeroOneSystem\\Desktop\\Final Contacts Project\\api\\Prof.jpg"));

            //new UserB().Add(new UserSignInM()
            //{
            // FullName = "mehdi",
            // ImgData = imgdata,
            // Password = "2719",
            // PasswordConfirm ="2719",
            // UserName = "mahdi007@gmailcom",
            //});

            //BResultM<int> result = new UserB().SignUP(new UserSignUPM()
            //{
            //    UserName = "mohammadrezakarimi@gmail.com",
            //    Password = "2719"
            //});

            //BResultM<UserProfileM> result = new UserB().Profile(1002);
        }
    }
}
