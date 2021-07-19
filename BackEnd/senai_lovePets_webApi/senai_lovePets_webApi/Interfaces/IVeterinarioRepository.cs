using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IVeterinarioRepository
    {

        List<Veterinario> ListarTodos();

        Veterinario BuscarPorId(int idVeterinario);

        void Cadastrar(Veterinario novoVerterinario);

        void Atualizar(int idVeterinario, Veterinario veterinarioAtualizado);

        void Deletar(int idVeterinario);

    }
}
