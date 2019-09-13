using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoPets.Ui.Data;
using ContosoPets.Ui.Models;

namespace ContosoPets.Ui.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly ContosoPets.Ui.Data.ContosoPetsContext _context;

        public DetailsModel(ContosoPets.Ui.Data.ContosoPetsContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers
                    .Include(c => c.Orders)
                    .SingleAsync(c => c.Id == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
