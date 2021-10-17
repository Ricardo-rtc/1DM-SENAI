using System;
using System.Collections.Generic;
using System.IO;
using ExemploEplayerMVC.Interfaces;

namespace ExemploEplayerMVC.Models
{
    public class Equipe : EPlayersBase, IEquipe
    {
        public int IdEquipe { get; set; }

        public string Nome { get; set; }

        public string Imagem { get; set; }

        private const string PATH = "Database/equipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(PATH);
        }

        public string Preparar(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }

        public void Alterar(Equipe e)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == e.IdEquipe.ToString());
            linhas.Add(Preparar(e));
            RewriteCSV(PATH, linhas);
        }

        public void Criar(Equipe e)
        {
            string[] linha = { Preparar(e) };
            File.AppendAllLines(PATH, linha);
        }

        public void Deletar(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            RewriteCSV(PATH, linhas);
        }

        public List<Equipe> LerTodas()
        {
            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Equipe equipe = new Equipe();

                equipe.IdEquipe = Int32.Parse(linha[0]);
                equipe.Nome = linha[1];
                equipe.Imagem = linha[2];

                equipes.Add(equipe);
            }
            return equipes;
        }
    }
}