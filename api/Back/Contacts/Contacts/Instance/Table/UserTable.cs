namespace Contacts.Instance.Table
{
    public class UserTable
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
    }
}
