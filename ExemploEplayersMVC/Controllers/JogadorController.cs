using ExemploEplayerMVC.Models;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ExemploEplayersMVC.Controllers
{
    [Route("Jogador")]
    public class JogadorController : Controller
    {
        
        Jogador jogadorModel = new Jogador();

        public IActionResult Index()
        {
            ViewBag.Jogadores = jogadorModel.LerTodas();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador     = new Jogador();
            novoJogador.IdJogador   = Int32.Parse(form["IdJogador"]);
            novoJogador.IdEquipe    = Int32.Parse(form["IdEquipe"]);
            novoJogador.Nome        = form["Nome"];
            novoJogador.Email       = form["Email"];
            novoJogador.Senha       = form["Senha"];

            jogadorModel.Criar(novoJogador);            
            ViewBag.Jogadores = jogadorModel.LerTodas();

            return LocalRedirect("~/Jogador");
        }
        
         [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            jogadorModel.Deletar(id);
            ViewBag.Equipes = jogadorModel.LerTodas();
            return LocalRedirect("~/Jogador/");
        }

    }
}