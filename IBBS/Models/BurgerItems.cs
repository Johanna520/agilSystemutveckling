using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBBS.Data;
using Microsoft.EntityFrameworkCore;

namespace IBBS.Models
{
    public class BurgerItems
    {
        public int Id { get; set; }
        public int Avocado { get; set; }
        public int Bacon { get; set; }
        public int BottomBunDark { get; set; }
        public int TopBunDark { get; set; }
        public int Cheese { get; set; }
        public int Chicken { get; set; }
        public int Cucumber { get; set; }
        public int Hahalloumi { get; set; }
        public int Ketchup { get; set; }
        public int Mayo { get; set; }
        public int Onion { get; set; }
        public int SalladBunBottom { get; set; }
        public int SalladBunTop { get; set; }
        public int TopLightBun { get; set; }
        public int Sallad { get; set; }
        public int Tomato { get; set; }
        public int Beef { get; set; }
        public int BottomLightBun { get; set; }
    }
}
