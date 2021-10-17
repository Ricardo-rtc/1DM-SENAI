using System.Collections.Generic;
using Projeto_Final_semestre.Models;

namespace Projeto_Final_semestre.Interfaces
{
    public interface IUsuario
    {
         void Criar(Usuario u);

         List<Usuario> LerTodas();

         void Alterar(Usuario u);

         void Deletar(int id);
    }
}