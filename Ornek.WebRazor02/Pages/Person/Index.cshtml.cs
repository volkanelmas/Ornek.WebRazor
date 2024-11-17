using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ornek.WebRazor02.Pages.Person
{
    public class IndexModel : PageModel
    {
        private readonly Ornek.WebRazor02.Models.MyDbContext _context;

        public IndexModel(Ornek.WebRazor02.Models.MyDbContext context)
        {
            _context = context;
        }
        public IList<Models.Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
