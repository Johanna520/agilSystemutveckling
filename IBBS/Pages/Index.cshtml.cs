using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using IBBS.Model;
using IBBS.Data;


namespace Testttt.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        private readonly IBBS.Data.ApplicationDbContext _context;

        public IndexModel(TodoApp.Data.TodoDbContext context)
        {
            _context = context;
        }


        public static void Burger()
        {
            List<string> burgerItem = new List<string>();

            burgerItem.Add("Bugerbun");
            burgerItem.Add("Beef");
            burgerItem.Add("Lettuce");
            burgerItem.Add("Tomato");
            burgerItem.Add("Ketchup");
        }

        public IList<Burger> Burgers { get; set; }

        public void OnGet()
        {

        }
    }
}
