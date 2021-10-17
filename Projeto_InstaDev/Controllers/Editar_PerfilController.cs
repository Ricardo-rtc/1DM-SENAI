using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final_semestre.Models;

namespace Projeto_Final_semestre.Controllers
{
    public class Editar_PerfilController : Controller
    {
        public IActionResult Index()
        {
            Usuario usuarioModel = new Usuario();
            ViewBag.Username = HttpContext.Session.GetString("_UserName");
            ViewBag.Usuarios = usuarioModel.LerTodas();
            return View();
        }
    }
}