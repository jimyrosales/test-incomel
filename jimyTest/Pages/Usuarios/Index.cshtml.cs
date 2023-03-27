using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using jimyTest.Models;

namespace jimyTest.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        private readonly jimytest _context;

        public IndexModel(jimytest context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Usuario != null)
            {
                Usuario = await _context.Usuario.ToListAsync();
            }
        }
    }
}
