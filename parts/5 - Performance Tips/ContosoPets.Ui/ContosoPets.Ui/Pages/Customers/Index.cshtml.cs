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
    public class IndexModel : PageModel
    {
        private readonly ContosoPets.Ui.Data.ContosoPetsContext _context;

        public IndexModel(ContosoPets.Ui.Data.ContosoPetsContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
