using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoPets.Ui.Data;
using ContosoPets.Ui.Models;

namespace ContosoPets.Ui.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ContosoPetsContext _context;

        public IndexModel(ContosoPetsContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .ToListAsync();
        }
    }
}
