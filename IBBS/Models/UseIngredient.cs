using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBS.Models

{
    public class UseIngredient
    {
        public int Id { get; set; }
        public Ingredient Ingredients { get; set; }
        public int Count { get; set; }
        public SavedHamburgers SavedHamburgers { get; set; }

    }
}
