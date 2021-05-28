using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testttt.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
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

        public void OnGet()
        {

        }
    }
}
