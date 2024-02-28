using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SignalRAssignment.Data;
using SignalRAssignment.Models;

namespace SignalRAssignment.Pages.Ercomerce
{
    public class IndexModel : PageModel
    {
        private readonly SignalRAssignment.Data.ApplicationContext _context;

        public IndexModel(SignalRAssignment.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .Include(p => p.Supplier).ToListAsync();
        }
    }
}
