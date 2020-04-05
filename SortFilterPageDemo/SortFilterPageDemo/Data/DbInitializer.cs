using SortFilterPageDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortFilterPageDemo.Data
{
    public class DbInitializer
    {
        public static void Initialize(MeuDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Alunos.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Aluno[]
            {
            new Aluno{Nome="Carson"},
            new Aluno{Nome="Harry"},
            new Aluno{Nome="Alan"},
            new Aluno{Nome="Phil"},
            new Aluno{Nome="Dean"},
            new Aluno{Nome="Cole"},
            new Aluno{Nome="Ashley"},
            new Aluno{Nome="Aaron"},
            new Aluno{Nome="Eric"},
            new Aluno{Nome="Michael"},
            };
            foreach (Aluno s in students)
            {
                context.Alunos.Add(s);
            }
            context.SaveChanges();
        }
    }
}
