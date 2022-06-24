using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROFI.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Star { get; set; }
        public bool IsDeleted { get; set; }
    }
}
