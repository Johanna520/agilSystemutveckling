using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBBS.Data;
using IBBS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace IBBS.Pages
{

    [Authorize]
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

        public List<Comments> commentList { get; set; }
        public async Task OnGetAsync(int? id)
        {
            if (id != null)
            {
                var commentList = await _context.Comments.FindAsync(id);


                _context.Update(commentList);
                await _context.SaveChangesAsync();
            }

            commentList = await _context.Comments.ToListAsync();
        }

        [BindProperty]
        public Comments newComment { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {

            newComment.User = await _context.Users.FirstOrDefaultAsync();

            await _context.AddAsync(newComment);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}