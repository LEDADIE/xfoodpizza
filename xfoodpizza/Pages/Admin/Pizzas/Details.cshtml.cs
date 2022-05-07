using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using xfoodpizza.Data;
using xfoodpizza.Models;

namespace xfoodpizza.Pages.Admin.Pizzas
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly xfoodpizza.Data.DataContext _context;

        public DetailsModel(xfoodpizza.Data.DataContext context)
        {
            _context = context;
        }

        public Pizza Pizza { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizza = await _context.Pizzas.FirstOrDefaultAsync(m => m.PizzaID == id);

            if (Pizza == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}