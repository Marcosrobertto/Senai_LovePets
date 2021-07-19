using senai_lovePets_webApi.Context;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class PetRepository : IPetRepository
    {

        lovePetsContext ctx = new lovePetsContext();
        public void Atualizar(int idPet, Pet petAtualizado)
        {
            Pet petBuscado = BuscarPorId(idPet);

            if (petAtualizado.NomePet != null)
            {
                petBuscado.NomePet = petAtualizado.NomePet;
            }

            if (petAtualizado.DataNascimento <= DateTime.Today)
            {
                petBuscado.DataNascimento = petAtualizado.DataNascimento;
            }

            ctx.Pets.Update(petBuscado);

            ctx.SaveChanges();
        }

        public Pet BuscarPorId(int idPet)
        {
            return ctx.Pets.Find(idPet);
        }

        public void Cadastrar(Pet novoPet)
        {
            ctx.Pets.Add(novoPet);

            ctx.SaveChanges();
        }

        public void Deletar(int idPet)
        {
            ctx.Pets.Remove(BuscarPorId(idPet));

            ctx.SaveChanges();
        }

        public List<Pet> ListarTodos()
        {
            return ctx.Pets.ToList();
        }
    }
}
