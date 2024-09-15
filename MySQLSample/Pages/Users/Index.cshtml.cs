using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MySQLSample.Data;
using MySQLSample.Models;

namespace MySQLSample.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly MySQLSample.Data.MySQLSampleContext _context;

        public IndexModel(MySQLSample.Data.MySQLSampleContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
