using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using xfoodpizza.Data;
using xfoodpizza.Models;

namespace xfoodpizza.Pages.Admin.Pizzas
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly xfoodpizza.Data.DataContext _context;

        public CreateModel(xfoodpizza.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pizza Pizza { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pizzas.Add(Pizza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}