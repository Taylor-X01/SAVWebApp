using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAVWebApp.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public string ClientID { get; set; }
        public string ClientName { get; set; }
        public DateTime RDate { get; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string NSerie { get; set; }

        public Request()
        {
            this.RDate = DateTime.Now;
        }
    }
}
