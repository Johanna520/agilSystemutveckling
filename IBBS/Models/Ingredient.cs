using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBS.Models
{
    public class Ingredient 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UseIngredient> UseIngredients { get; set; }

    }
}
