using System;
using System.Collections.Generic;
using System.IO;
using Projeto_Final_semestre.Interfaces;

namespace Projeto_Final_semestre.Models
{
    public class Post : InstadevBase, IPost
    {
        public int IdPost { get; set; }
        public int comentarios { get; set; }
        public string Imagem { get; set; }
        public string ImagemUsuario { get; set; }
        public string descricao { get; set; }
        public string Usuario { get; set; }
        private string PATH = "Database/post.csv";

        public Post()
        {
            CreateFolderAndFile(PATH);
        }

        private string PrepararLinha(Post p)
        {
            return $"{p.Usuario};{p.ImagemUsuario};{p.IdPost};{p.comentarios};{p.Imagem};{p.descricao}";
        }

        public void Alterar(Post p)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split("/")[0] == p.IdPost.ToString());
            linhas.Add(PrepararLinha(p));
            RewriteCSV(PATH, linhas);
        }

        public void Criar(Post p)
        {
            string[] linha = { PrepararLinha(p) };
            File.AppendAllLines(PATH, linha);
        }

        public void Deletar(int idPost)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[2] == idPost.ToString());
            RewriteCSV(PATH, linhas);
        }

        public List<Post> ReadAll()
        {
            List<Post> posts = new List<Post>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Post post = new Post();

                post.Usuario = linha[0];
                post.ImagemUsuario = linha[1];
                post.IdPost = Int32.Parse(linha[2]);
                post.comentarios = Int32.Parse(linha[3]);
                post.Imagem = linha[4];
                post.descricao = linha[5];

                posts.Add(post);
            }

            return posts;
        }

    }
}