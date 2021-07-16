using senai_lovePets_webApi.Context;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class RacaRepository : IRacaRepository
    {
        lovePetsContext ctx = new lovePetsContext();
        public void Atualizar(int idRaca, Raca RacaAtualizada)
        {
            Raca racaBuscada = BuscarPorId(idRaca);

            if (RacaAtualizada.NomeRaca !=null)
            {
                racaBuscada.NomeRaca = RacaAtualizada.NomeRaca;
            }

            if (RacaAtualizada.IdTipoPet >0)
            {
                racaBuscada.IdTipoPet = RacaAtualizada.IdTipoPet;
            }

            ctx.Racas.Update(racaBuscada);

            ctx.SaveChanges();
        }

        public Raca BuscarPorId(int idRaca)
        {
            return ctx.Racas.Find(idRaca);
        }

        public void Cadastrar(Raca novaRaca)
        {
            ctx.Racas.Add(novaRaca);

            ctx.SaveChanges();
        }

        public void Deletar(int idRaca)
        {
            ctx.Racas.Remove(BuscarPorId(idRaca));
        }

        public List<Raca> Listar()
        {
            return ctx.Racas.ToList();
        }
    }
}
