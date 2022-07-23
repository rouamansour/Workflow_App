using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Position Position { get; internal set; }
        public int PositionId { get; set; }
        //public UserRequest UserRequests { get; internal set; }
        public List<UserRequest> UserRequests { get; set; }
        public ICollection<Request> Requests { get; set; }

    }
}
