using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final_semestre.Models;

namespace Projeto_Final_semestre.Controllers
{
    // [Route("Cadastro")]
    public class HomeController : Controller
    {
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {

            ViewBag.UserName = HttpContext.Session.GetString("_UserName");
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Usuario novoUsuario = new Usuario();
            Random randomico = new Random();


            novoUsuario.IdUsuario = randomico.Next(50000);
            novoUsuario.Nome = form["Nome"];
            novoUsuario.Username = form["Username"];
            novoUsuario.Email = form["Email"];
            novoUsuario.Senha = form["Senha"];

            if (form.Files.Count > 0)
            {

                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Posts");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novoUsuario.Imagem = file.FileName;
            }

            else
            {
                novoUsuario.Imagem = "padrao.png";
            }

            usuarioModel.Criar(novoUsuario);
            ViewBag.Usuarios = usuarioModel.LerTodas();

            return LocalRedirect("~/Login/");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            usuarioModel.Deletar(id);
            ViewBag.Usuarios = usuarioModel.LerTodas();
            return LocalRedirect("~/Usuario/Listar");
        }
    }
}