using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBBS.Data;
using IBBS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace IBBS.Pages
{
    public class BurgerPageModel : PageModel
    {
        private readonly BurgerDbContext _context;
        private readonly UserManager<Users> _userManager;
        public BurgerPageModel(BurgerDbContext context,
            UserManager<Users> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        //Hämtar en lista med komentarer, detta för att kunna visa samtliga kommentarer. Inte irkigt klar med hur
        // den ska se ut i cshtml-koden men är "under construction". 

        public IList<Comments> commentList { get; set; }
        public async Task OnGetAsync()
        {
            commentList = await _context.Comments.ToListAsync();
        }

        [BindProperty]
        public Comments Comments { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD

        //sparar ner commentarer och kopplar samman med userID om du är inloggad
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //Claimar User-model 
                var user = await _userManager.GetUserAsync(User);
                Comments.User = user;
                _context.Add(Comments);
                await _context.SaveChangesAsync();

                return Page();
            }
            return RedirectToPage("/Index");
        }
    }
}
