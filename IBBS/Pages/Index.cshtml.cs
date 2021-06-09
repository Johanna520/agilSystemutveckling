using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using IBBS.Models;
using IBBS.Data;


namespace IBBS.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BurgerDbContext _context;

        public IndexModel(BurgerDbContext context)
        {

            _context = context;
        }

        public void OnGet() {

        }

    }
}