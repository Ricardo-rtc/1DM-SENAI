using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Final_semestre.Models;

namespace Projeto_Final_semestre.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        Usuario usuarioModel = new Usuario();

        [TempData]
        public string Mensagem { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            // Lemos todos os arquivos do CSV
            List<string> csv = usuarioModel.ReadAllLinesCSV("Database/usuario.csv");

            // Verificamos se as informações passadas existe na lista de string
            var logado = csv.Find(
                x =>
                x.Split(";")[3] == form["Email"] &&
                x.Split(";")[4] == form["Senha"]
            );


            // Redirecionamos o usuário logado caso encontrado
            if (logado != null)
            {
                // Definimos os valores a serem salvos na sessão
                HttpContext.Session.SetString("_Nome", logado.Split(";")[1]);
                HttpContext.Session.SetString("_UserName", logado.Split(";")[2]);
                HttpContext.Session.SetString("_UserImagem", logado.Split(";")[5]);

                return LocalRedirect("~/Feed/Listar");
            }
            else
            {

                Mensagem = "Dados incorretos, tente novamente...";

            }
            return LocalRedirect("~/");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("_UserName");
            return LocalRedirect("~/");
        }


    }
}