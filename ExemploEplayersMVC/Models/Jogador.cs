using System;
using System.Collections.Generic;
using System.IO;
using ExemploEplayersMVC.Interfaces;

namespace ExemploEplayerMVC.Models
{
    public class Jogador : EPlayersBase, IJogador
    {
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int IdEquipe { get; set; }
        private const string PATH = "Database/Jogador.csv";

        public Jogador(){
            CreateFolderAndFile(PATH);
        }

        private string PrepararLinha(Jogador j)
        {
            return $"{j.IdJogador};{j.Nome};{j.Email};{j.Senha};{j.IdEquipe}";
        }

        public void Alterar(Jogador j)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == IdJogador.ToString());
            linhas.Add(PrepararLinha(j));
            RewriteCSV(PATH, linhas);
        }

        public void Criar(Jogador j)
        {
            string[] linha = { PrepararLinha(j) };
            File.AppendAllLines(PATH, linha);
        }

        public void Deletar(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            RewriteCSV(PATH, linhas);
        }

        public List<Jogador> LerTodas()
        {
            List<Jogador> jogadores = new List<Jogador>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Jogador jogador = new Jogador();

                jogador.IdJogador = Int32.Parse(linha[0]);
                jogador.Nome = linha[1];
                jogador.Email = linha[2];
                jogador.Senha = linha[3];
                jogador.IdEquipe = int.Parse(linha[4]);

                jogadores.Add(jogador);
            }
            return jogadores;
        }

         public void Update(Jogador j)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == j.IdJogador.ToString());
            linhas.Add( PrepararLinha(j) );                        
            RewriteCSV(PATH, linhas); 
        }

        
    }
}