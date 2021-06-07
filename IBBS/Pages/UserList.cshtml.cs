using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IBBS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace IBBS.Pages
{
    public class UserListModel : PageModel
    {
        private readonly Data.BurgerDbContext _context;
        private readonly UserManager<Users> _userManager;

        public UserListModel(Data.BurgerDbContext context, UserManager<Users> userManager)
        {
            _context = context;
            _userManager = userManager;

        }


        public IList<Users> Users { get; set; }
        [BindProperty(SupportsGet=true)]
        public string SearchTerm { get; set; }



        public async Task OnGetAsync()
        {
            if (string.IsNullOrEmpty(SearchTerm))
            {
                Users = await _context.Users.ToListAsync();
            }
            else
            {
                Users = await _context.Users.Where(u => (u.FirstName + " " + u.LastName).Contains(SearchTerm) ||
                                                         u.Email.Contains(SearchTerm)).ToListAsync();
            }
            
        }

        public async Task<IActionResult> OnPostMakeAdminAsync(string UserName)
        {
            var user = await _context.Users.Where(u => u.UserName == UserName).FirstOrDefaultAsync();
            await _userManager.AddToRoleAsync(user, "Admin");
            await _context.SaveChangesAsync();

            Users = await _context.Users.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostRemoveAdminAsync(string UserName)
        {
            var user = await _context.Users.Where(u => u.UserName == UserName).FirstOrDefaultAsync();
            await _userManager.RemoveFromRoleAsync(user, "Admin");
            await _context.SaveChangesAsync();

            Users = await _context.Users.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostBanUserAsync(string UserName)
        {
            var user = await _context.Users.Where(u => u.UserName == UserName).FirstOrDefaultAsync();
            var lockoutEndDate = new DateTime(2999, 01, 01);
            await _userManager.SetLockoutEnabledAsync(user, true);
            await _userManager.SetLockoutEndDateAsync(user, lockoutEndDate);

            Users = await _context.Users.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostRemoveBanAsync(string UserName)
        {
            var user = await _context.Users.Where(u => u.UserName == UserName).FirstOrDefaultAsync();
            await _userManager.SetLockoutEnabledAsync(user, false);

            Users = await _context.Users.ToListAsync();
            return Page();
        }
        public async Task<IActionResult> OnPostRemoveAccountAsync(string UserName)
        {
            var user = await _context.Users.Where(u => u.UserName == UserName).FirstOrDefaultAsync();
            await _userManager.DeleteAsync(user);

            Users = await _context.Users.ToListAsync();
            return Page();
        }
    }
}
