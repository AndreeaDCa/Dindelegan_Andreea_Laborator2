using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dindelegan_Andreea_Laborator2.Data;
using Dindelegan_Andreea_Laborator2.Models;

namespace Dindelegan_Andreea_Laborator2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Dindelegan_Andreea_Laborator2.Data.Dindelegan_Andreea_Laborator2Context _context;

        public IndexModel(Dindelegan_Andreea_Laborator2.Data.Dindelegan_Andreea_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;
        public int CategoryID { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
