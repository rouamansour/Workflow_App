using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public int Number { get; set; }
        public string Comment { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public TypeRequest TypeRequest { get; internal set; }
        // public UserRequest UserRequests { get; internal set; }
        public List<UserRequest> UserRequests { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
