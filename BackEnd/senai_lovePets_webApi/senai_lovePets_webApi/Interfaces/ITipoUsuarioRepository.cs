using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {

        List<TipoUsuario> ListarTodos();

        TipoUsuario BuscarPorId(int idTipoUsuario);

        void Cadastrar(TipoUsuario novoTipoUsurio);

        void Atualizar(int idTipoUsuario, TipoUsuario tipoUsuarioAtualizado);

        void Deletar(int idTipoUsuario);

    }
}
