using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBBS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace IBBS.Pages
{
    public class CreateBurgerModel : PageModel
    {
        private readonly IBBS.Data.BurgerDbContext _context;

        public CreateBurgerModel(IBBS.Data.BurgerDbContext context)
        {
            _context = context;
        }

        public List<Ingredient> Ingredients { get; set; }

        public async Task OnGetAsync()
        {
            Ingredients = await _context.Ingredients.ToListAsync();
        }

    }
}
