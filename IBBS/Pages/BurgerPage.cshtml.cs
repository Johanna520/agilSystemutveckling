using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IBBS.Models;
using Microsoft.EntityFrameworkCore;

namespace IBBS.Pages
{
    public class BurgerPageModel : PageModel
    {

        private readonly IBBS.Data.BurgerDbContext _context;

        public BurgerPageModel(IBBS.Data.BurgerDbContext context)
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
