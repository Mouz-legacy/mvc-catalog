using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_953502_Strelets.Data;
using Web_953502_Strelets.Entities;

namespace Web_953502_Strelets.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Web_953502_Strelets.Data.ApplicationDbContext _context;

        public IndexModel(Web_953502_Strelets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Cars
                .Include(c => c.Group).ToListAsync();
        }
    }
}
