namespace SAVWebApp.Models
{
    public class Client
    {
        public int id { get; set; }
        public string clientName { get; set; }
        public string contactName { get; set; }
        public string email { get; set; }
        public string passwd { get; set; }
        public string phoneNum { get; set; }
        public string fax { get; set; }

        public Client()
        {

        }
    }
}
