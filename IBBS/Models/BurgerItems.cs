using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBBS.Data;
using Microsoft.EntityFrameworkCore;

namespace IBBS.Models
{
    [Keyless]
    public class BurgerItems
    {
        public string Burgerbun { get; set; }
        public string Protein { get; set; }
        public string Vegetables { get; set; }
        public string Sauce { get; set; }

    }
}
