using Raven.Client.Documents.Indexes;
using System.Linq;

namespace V___CreatingARavenIndexWithCSharp.Indexes
{
    public class Employes_ByFirstAndLastName : AbstractIndexCreationTask<Employee>
    {
        public Employes_ByFirstAndLastName()
        {
            Map = (employees) =>
                from employee in employees
                select new
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName
                };
        }
    }
}
