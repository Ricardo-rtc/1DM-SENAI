using System.Collections.Generic;
using ExemploEplayerMVC.Models;

namespace ExemploEplayersMVC.Interfaces
{
    public interface IJogador
    {
         void Criar(Jogador j);

         List<Jogador> LerTodas();

         void Alterar(Jogador j);
         void Deletar(int id);
    }
}