using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IBBS.Models
{
    public class Likes
    {
        public int Id { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public Users Users { get; set; }
        public SavedHamburgers Burgers { get; set; }

    }

    public class LikesDTO
    {
        public int Like { get; set; }
        public int Dislike { get; set; }

        //public SavedHamburgers Burgers { get; set; }
    }
}
