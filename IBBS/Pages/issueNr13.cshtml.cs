using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IBBS.Data;
using IBBS.Models;
using Microsoft.AspNetCore.Identity;

namespace IBBS.Pages
{
    // this is a scaffolded creat-page!
    public class issueNr13Model : PageModel
    {
        private readonly BurgerDbContext _context;
        private readonly UserManager<Users> _userManager;
        public issueNr13Model(BurgerDbContext context,
            UserManager<Users> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Comments Comments { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Comments.Add(Comments);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
