namespace Contacts.Instance.Table
{
    public class ContactsTable
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] Pass { get; set; }
    }
}
