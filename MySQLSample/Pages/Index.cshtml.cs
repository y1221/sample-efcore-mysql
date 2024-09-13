using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MySQLSample.Data;
using MySQLSample.Models;

namespace MySQLSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MySQLSampleContext _context;

        public IList<User> Users { get; set; } = default!;

        public IndexModel(ILogger<IndexModel> logger, MySQLSampleContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Users = await _context.User.ToListAsync();
        }
    }
}
