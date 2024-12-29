namespace Contacts.Instance
{
    public class BResultM<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

    }
}
