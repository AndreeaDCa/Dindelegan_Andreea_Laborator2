using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dindelegan_Andreea_Laborator2.Data;
using Dindelegan_Andreea_Laborator2.Models;
using Microsoft.AspNetCore.Authorization;

namespace Dindelegan_Andreea_Laborator2.Pages.Publishers
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly Dindelegan_Andreea_Laborator2.Data.Dindelegan_Andreea_Laborator2Context _context;

        public CreateModel(Dindelegan_Andreea_Laborator2.Data.Dindelegan_Andreea_Laborator2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
