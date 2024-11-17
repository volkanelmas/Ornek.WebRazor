using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ornek.WebRazor02.Models;

namespace Ornek.WebRazor02.Pages.Person
{
    public class DetailsModel : PageModel
    {
        private readonly Ornek.WebRazor02.Models.MyDbContext _context;

        public DetailsModel(Ornek.WebRazor02.Models.MyDbContext context)
        {
            _context = context;
        }

        public Models.Person Person { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Persons.FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            else
            {
                Person = person;
            }
            return Page();
        }
    }
}
