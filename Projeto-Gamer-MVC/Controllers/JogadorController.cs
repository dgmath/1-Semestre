using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer_MVC.Infra;
using Projeto_Gamer_MVC.Models;

// [Route("Listar")]
// public IActionResult Index()
// {
//     ViewBag.Equipe = c.Equipe.ToList();

//     return View();
// }
namespace Projeto_Gamer_MVC.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogador = c.Jogador.ToList();

            ViewBag.Equipe = c.Equipe.ToList();

            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form, Equipe ee)
        {
            Jogador novoJogador = new Jogador();
            Equipe e = new Equipe();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["Equipe"]);
            // novoJogador.Equipe = c.Equipe.First(e => e.IdEquipe == int.Parse(form["Equipe"]));

            c.Jogador.Add(novoJogador);
            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }


        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Jogador j = c.Jogador.First(j => j.IdJogador == id);

            c.Jogador.Remove(j);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            Jogador jojo = c.Jogador.First(j => j.IdJogador == id);

            ViewBag.Jogador = jojo;
           ViewBag.Equipe = c.Equipe.ToList();
            return View("Edit");

        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.IdJogador = int.Parse(form["IdJogador"].ToString());
            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            Jogador jogadorBuscado = c.Jogador.First(j => j.IdJogador == novoJogador.IdJogador);

            jogadorBuscado.Nome = novoJogador.Nome;
            jogadorBuscado.Email = novoJogador.Email;
            jogadorBuscado.Senha = novoJogador.Senha;
            jogadorBuscado.IdEquipe = novoJogador.IdEquipe;

            c.Jogador.Update(jogadorBuscado);
            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}