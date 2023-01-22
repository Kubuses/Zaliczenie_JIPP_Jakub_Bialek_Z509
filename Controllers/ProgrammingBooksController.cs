using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Zaliczenie_JIPP_Jakub_Bialek.Data;
using Zaliczenie_JIPP_Jakub_Bialek.Models;

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

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProgrammingBookModel programmingBook) 
        {
            if(ModelState.IsValid) 
            { 
                try
                {
                    await _context.ProgrammingBooks.AddAsync(programmingBook);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Something went wrong{ex.Message}");
                }
            }

            ModelState.AddModelError(string.Empty, "Something went wrong");
            return View(programmingBook);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var programmingBook = await _context.ProgrammingBooks.FirstOrDefaultAsync(x => x.ID == id);
            return View(programmingBook);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProgrammingBookModel programmingBook)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var exist = await _context.ProgrammingBooks.FirstOrDefaultAsync(x => x.ID == programmingBook.ID);

                    if(exist != null) 
                    { 
                        exist.Author = programmingBook.Author;
                        exist.Title= programmingBook.Title;
                        exist.PublishYear = programmingBook.PublishYear;

                        await _context.SaveChangesAsync();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError(string.Empty, "Invalid book to update");
                    return View(programmingBook);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Invalid book to update {ex.Message}");
                }
            }

            ModelState.AddModelError(string.Empty, "Something went wrong");
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var programmingBook = await _context.ProgrammingBooks.FirstOrDefaultAsync(x => x.ID == id);
            return View(programmingBook);
        }
    }
}
