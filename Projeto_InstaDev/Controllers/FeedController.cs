using System;
using System.IO;
using Projeto_Final_semestre.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projeto_Final_semestre.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {
        Post postModel = new Post();
        Usuario usuarioModel = new Usuario();


        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Username = HttpContext.Session.GetString("_UserName");
            ViewBag.Nome = HttpContext.Session.GetString("_Nome");
            ViewBag.Posts = postModel.ReadAll();
            ViewBag.Usuarios = usuarioModel.LerTodas();
            return View();
        }

        [Route("Postar")]
        public IActionResult Postar(IFormCollection form)
        {
            Usuario usuario = new Usuario();
            Random randomico = new Random();
            Random randomico2 = new Random();
            Post novoPost = new Post();

            novoPost.Usuario = HttpContext.Session.GetString("_UserName");
            novoPost.ImagemUsuario = HttpContext.Session.GetString("_UserImagem");
            novoPost.IdPost = randomico.Next(50000);
            novoPost.comentarios = randomico2.Next(50000);


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

                novoPost.Imagem = file.FileName;
            }

            else
            {
                novoPost.Imagem = "padrao.png";
            }

            novoPost.descricao = form["descricao"];

            postModel.Criar(novoPost);

            ViewBag.Posts = postModel.ReadAll();

            return LocalRedirect("~/Feed/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            postModel.Deletar(id);
            ViewBag.Posts = postModel.ReadAll();
            return LocalRedirect("~/Perfil/Listar");
        }
    }
}