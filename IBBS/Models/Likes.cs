using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBS.Models
{
    public class Likes
    {
        public int Up { get; set; }
        public int Down { get; set; }
        public Users Users { get; set; }
        public List<SavedHamburgers> Burgers { get; set; }

    }
}
