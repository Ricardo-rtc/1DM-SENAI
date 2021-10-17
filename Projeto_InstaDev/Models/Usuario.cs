using System;
using System.Collections.Generic;
using System.IO;
using Projeto_Final_semestre.Interfaces;

namespace Projeto_Final_semestre.Models
{
    public class Usuario : InstadevBase, IUsuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int numbers { get; set; }
        private const string PATH = "Database/usuario.csv";

        public Usuario()
        {
            CreateFolderAndFile(PATH);
        }

        private string PrepararLinha(Usuario u)
        {
            return $"{u.IdUsuario};{u.Nome};{u.Username};{u.Email};{u.Senha};{u.Imagem}";
        }

        public void Alterar(Usuario u)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == IdUsuario.ToString());
            linhas.Add(PrepararLinha(u));
            RewriteCSV(PATH, linhas);
        }

        public void Criar(Usuario u)
        {
            string[] linha = { PrepararLinha(u) };
            File.AppendAllLines(PATH, linha);
        }

        public void Deletar(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            RewriteCSV(PATH, linhas);
        }

        public List<Usuario> LerTodas()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Usuario usuario = new Usuario();

                usuario.IdUsuario = Int32.Parse(linha[0]);
                usuario.Nome = linha[1];
                usuario.Username = linha[2];
                usuario.Email = linha[3];
                usuario.Senha = linha[4];
                usuario.Imagem = linha[5];

                usuarios.Add(usuario);
            }
            return usuarios;
        }
    }
}