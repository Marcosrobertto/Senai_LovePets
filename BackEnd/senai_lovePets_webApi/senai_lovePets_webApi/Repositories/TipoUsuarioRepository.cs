using senai_lovePets_webApi.Context;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{

    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        lovePetsContext ctx = new lovePetsContext();
        public void Atualizar(int idTipoUsuario, TipoUsuario tipoUsuarioAtualizado)
        {
            TipoUsuario tipoUsuarioBuscado = BuscarPorId(idTipoUsuario);

            if (tipoUsuarioAtualizado.NomeTipoUsuario != null)
            {
                tipoUsuarioBuscado.NomeTipoUsuario = tipoUsuarioAtualizado.NomeTipoUsuario;
            }

            ctx.TipoUsuarios.Update(tipoUsuarioBuscado);

            ctx.SaveChanges();
        }

        public TipoUsuario BuscarPorId(int idTipoUsuario)
        {
            return ctx.TipoUsuarios.Find(idTipoUsuario);
        }

        public void Cadastrar(TipoUsuario novoTipoUsurio)
        {
            ctx.TipoUsuarios.Add(novoTipoUsurio);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipoUsuario)
        {
            ctx.TipoUsuarios.Remove(BuscarPorId(idTipoUsuario));
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}
