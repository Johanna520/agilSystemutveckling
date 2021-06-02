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


        //public static void Burger()
        //{
        //    List<string> burgerItem = new List<string>();
        //
        //    burgerItem.Add("Bugerbun");
        //    burgerItem.Add("Beef");
        //    burgerItem.Add("Lettuce");
        //    burgerItem.Add("Tomato");
        //    burgerItem.Add("Ketchup");
        //}

        //public IList<BurgerItems> BurgerItem { get; set; }

        public void OnGet() {

            //BurgerItem = _context.BurgerItems.ToList();

        }

    }
}