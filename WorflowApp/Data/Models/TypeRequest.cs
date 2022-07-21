using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TypeRequest
    {
        [Key]
        public int TypeId { get; set; }
        public string Description { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
