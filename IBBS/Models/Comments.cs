using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBS.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public Users User { get; set; }
        public SavedHamburgers Burger { get; set; }
    }
}
