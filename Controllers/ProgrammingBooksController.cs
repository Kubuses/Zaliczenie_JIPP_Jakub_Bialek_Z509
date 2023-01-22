using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Zaliczenie_JIPP_Jakub_Bialek.Data;

namespace Zaliczenie_JIPP_Jakub_Bialek.Controllers
{
    public class ProgrammingBooksController : Controller
    {
        private ProgrammingBookContext _context;

        public ProgrammingBooksController(ProgrammingBookContext context)
        {
            _context= context;
        }

        public async Task<IActionResult> Index()
        {
            var programmingBooks = await _context.ProgrammingBooks.ToListAsync();
            return View(programmingBooks);
        }
    }
}
