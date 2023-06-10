using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace aula29.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string getId(int ID)
        {
            return HtmlEncoder.Default.Encode($"Peguei o id {ID}");
        }

        public IActionResult Parametros(string nome, int ID)
        {
            ViewData["name"] = "aaaaaaa";
            ViewData["ID"] = ID;

            return View();
        }
    }
}
