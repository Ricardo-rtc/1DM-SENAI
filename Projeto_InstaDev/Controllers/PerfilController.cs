using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final_semestre.Models;

namespace Projeto_Final_semestre.Controllers
{

    [Route("Perfil")]
    public class PerfilController : Controller
    {
        Post postModel = new Post();
        Usuario usuarioModel = new Usuario();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Username = HttpContext.Session.GetString("_UserName");
            ViewBag.Nome = HttpContext.Session.GetString("_Nome");
            ViewBag.Userimagem = HttpContext.Session.GetString("_UserImagem");
            ViewBag.Posts = postModel.ReadAll();
            ViewBag.Usuarios = usuarioModel.LerTodas();
            return View();
        }
    }
}