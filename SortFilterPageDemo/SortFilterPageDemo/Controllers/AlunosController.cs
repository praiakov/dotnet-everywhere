using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SortFilterPageDemo.Configuration;
using SortFilterPageDemo.Data;
using SortFilterPageDemo.Models;
using System.Threading.Tasks;
using System.Linq;
using ReflectionIT.Mvc.Paging;

namespace SortFilterPageDemo.Controllers
{
    public class AlunosController : Controller
    {
        private readonly MeuDbContext _context;

        public AlunosController(MeuDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IActionResult> Index(string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;

            var students = from s in _context.Alunos
                           select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Nome.Contains(searchString));
            }


            int pageSize = 3;

            return View(await PaginatedList<Aluno>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize));

        }

    }
}