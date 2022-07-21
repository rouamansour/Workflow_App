using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Title { get; set; }
        public List<User> Users { get; set; }
    }
}
