using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBBS.Data;
using Microsoft.EntityFrameworkCore;

namespace IBBS.Model
{
    public class BurgerItems
    {
        public int ID { get; set; }
        public string Burgerbun { get; set; }
        public string Beef { get; set; }
        public string Lettuce { get; set; }
        public string Tomato { get; set; }
        public string Ketchup { get; set; }

    }
}
