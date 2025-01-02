using System.Security.Cryptography;
using System.Text;
using Contacts.Instance.User;
using Contacts.Instance.Table;
using Contacts.Instance;
using Contacts.DAccess;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace Contacts.BLogic
{
    public class UserB
    {
     

        public BResultM<int> SignInB(UserSignInM model)
        {

            BResultM<int> result = new();
            if (model.Password != model.PasswordConfirm)
            {
                result.Success = false;
                result.ErrorCode = 1001;
                result.ErrorMessage = "Paassword Does Not Match";

                return result;
            }
            if (model.UserName.Length > 64 || model.FullName.Length > 64)
            {
                result.Success = false;
                result.ErrorCode = 1002;
                result.ErrorMessage = "Paassword Does Not Match";

                return result;
            }
            byte[] avatar = null;
            try
            {
                avatar = Convert.FromBase64String(model.ImgData);
            }
            catch (FormatException)
            {
                result.Success = false;
                result.ErrorCode = 1003;
                result.ErrorMessage = "Invalid image data format.";
                return result;
            }
        

            byte[] password = MD5.HashData(Encoding.UTF8.GetBytes(model.Password));
            //Sakhtan poshe avatar v hazf oon(Path  va Direcotry az w3school estefade shode )
            string avatarFolder = Path.Combine(Directory.GetCurrentDirectory(), "Avatar");

            if (!Directory.Exists(avatarFolder))
            {
                Directory.CreateDirectory(avatarFolder);
            }
            string file = Path.Combine(avatarFolder, $"{model.UserName.ToLower()}.jpg");

            if (File.Exists(file))
            {
                File.Delete(file);
            }

            File.WriteAllBytes(file, avatar);

            UserTable user = new()
            {
                UserName = model.UserName,
                FullName = model.FullName,
                Password = password,
                Avatar = model.UserName.ToLower(),
            };

            result.Data = new UserD().Insert(user);


            return result;

        }

        public BResultM<int> SignUpB(UserSignUPM model)
        {
            byte[] password = MD5.HashData(Encoding.UTF8.GetBytes(model.password));

            int id = new UserD().GetUserID(model.username, password);

            if (id == 0)
            {
                return new BResultM<int>()
                {
                    Success = false,
                    ErrorCode = 1004,
                    ErrorMessage = "Username or Password Was Wrong"
                };
             };

                return new BResultM<int>()
            {
                Success = true,
                Data = id
            };
        }
        public BResultM<UserProfileM> ProfileB(int userId)
        {
          UserTable info = new UserD().GetUserDetails(userId);

          string folder = Path.Combine(Directory.GetCurrentDirectory(), "Avatar");
          string avatar = Path.Combine(folder, $"{info.Avatar.ToLower()}.jpg");

            byte[] AvatarB = null;

            if (File.Exists(avatar))
            {
                AvatarB = File.ReadAllBytes(avatar);
            }


                return new BResultM<UserProfileM>()
            {
                Success = true,
                Data = new UserProfileM()
                {
                    Avatar = AvatarB,
                    Username = info.UserName,
                    FullName = info.FullName,
                }
            };
      
        }
    }
}

