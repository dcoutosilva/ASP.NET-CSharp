using ProjetoWeb.Models;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using System.Linq;

namespace ProjetoWeb.Controllers
{
    public class UsuarioController : Controller
    {
      
        public ActionResult Usuario()
        {
            var Usuario = new Usuario();
            return View(Usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O Campo Nome é obrigatório.");
            }

            if (usuario.Senha != usuario.ConfirmaSenha)
            {
                ModelState.AddModelError("", "As senhas são diferentes.");
            }

            if (usuario.Email != usuario.ConfirmaEmail)
            {
                ModelState.AddModelError("", "Os e-mails são diferentes.");
            }

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico (string login)
        {
            var bdexemplo = new Collection<string>
            {
                "Danilo",
                "Rony",
                "Fernando"
            };

            return Json(bdexemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}