using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBS.Models
{
    public class SavedHamburgers
    {
        public int Id { get; set; }
        public List<Likes> Likes { get; set; }
        public Users User { get; set; }
        public List<Comments> Comments { get; set; }
        public List<UseIngredient> UseIngredients { get; set; }
        // Vet inte om det är lösningen men vi behöver ju något som håller koll på hur hamburgaren faktiskt ser ut
    }
}
