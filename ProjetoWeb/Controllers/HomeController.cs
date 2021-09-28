using System.Web.Mvc;
using ProjetoWeb.Models;

namespace ProjetoWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                Codigo = 1,
                Nome = "teste",
                Cpf = "111.111.111-11",
                Rg = "99.999.999-9",
                DtNasc = "01/01/2000"

            };
            return View(pessoa);
        }

        public ActionResult Contato()
        {
            return View();

        }

        public ActionResult Sobre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            //ViewData["Codigo"] = pessoa.Codigo;
            //ViewData["Nome"] = pessoa.Nome ;
            //ViewData["Rg"] = pessoa.Rg ;
            //ViewData["Cpf"] = pessoa.Cpf;
            //ViewData["DtNasc"] = pessoa.DtNasc;

            return View(pessoa);
        }

    }
}