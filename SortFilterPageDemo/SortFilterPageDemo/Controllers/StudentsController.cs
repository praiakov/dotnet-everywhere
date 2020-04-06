using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using SortFilterPageDemo.Data;
using SortFilterPageDemo.Models;

namespace SortFilterPageDemo.Controllers
{
    public class StudentsController : Controller
    {
        private readonly MeuDbContext _context;

        public StudentsController(MeuDbContext dbContext)
        {
            _context = dbContext;
        }


        public IActionResult Index(int page = 1)
        {
            IEnumerable<Aluno> qry = _context.Alunos.AsNoTracking();
            var model = PagingList.Create(qry, 10, page);

            return View(model);
        }
    }
}