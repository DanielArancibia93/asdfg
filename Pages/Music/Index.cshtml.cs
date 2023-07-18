using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMusic.Data;
using RazorPagesMusic.Models;

namespace aspnetcoreapp.Pages_Music
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMusic.Data.RazorPagesMusicContext _context;

        public IndexModel(RazorPagesMusic.Data.RazorPagesMusicContext context)
        {
            _context = context;
        }

        public IList<Music> Music { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Music != null)
            {
                Music = await _context.Music.ToListAsync();
            }
        }
    }
}
