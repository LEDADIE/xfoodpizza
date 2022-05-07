using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

using System.Threading.Tasks;

using xfoodpizza.Models;

namespace xfoodpizza.Pages
{
    public class MenuPizzasModel : PageModel
    {
        private readonly Data.DataContext _context;

        public MenuPizzasModel(xfoodpizza.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get; set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
            Pizza = Pizza.OrderBy(p => p.prix).ToList();
        }
    }
}