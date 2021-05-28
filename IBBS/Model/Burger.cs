using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testttt.Data;
using Microsoft.EntityFrameworkCore;

namespace IBBS.Model
{
    public class Burger
    {
        public string Burgerbun { get; set; }
        public string Beef { get; set; }
        public string Lettuce { get; set; }
        public string Tomato { get; set; }
        public string Ketchup { get; set; }

    }
}
