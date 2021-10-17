using System.Collections.Generic;
using ExemploEplayerMVC.Models;

namespace ExemploEplayerMVC.Interfaces
{
    public interface IEquipe
    {
         void Criar(Equipe e);
         
         List<Equipe> LerTodas();

         void Alterar(Equipe e);

         void Deletar(int id);
    }
}