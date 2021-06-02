using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IBBS.Data;
using IBBS.Models;

namespace IBBS.Pages
{
    public class ListModel : PageModel
    {
        private readonly IBBS.Data.BurgerDbContext _context;

        public ListModel(IBBS.Data.BurgerDbContext context)
        {
            _context = context;
        }

        public IList<BurgerItems> BurgerItems { get;set; }

        public async Task OnGetAsync()
        {
            BurgerItems = await _context.BurgerItems.ToListAsync();
        }
    }
}
