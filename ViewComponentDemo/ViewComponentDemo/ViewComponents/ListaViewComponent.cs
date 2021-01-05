using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ViewComponentDemo.ViewComponents
{
    public class ListaViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(
            string sequencia)
        {
            var valores = await Task.FromResult(
                sequencia.Split(new char[] { '|' }));

            return View(valores);
        }
    }
}
