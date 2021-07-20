using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using senai_lovePets_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinariosController : ControllerBase
    {

        private IVeterinarioRepository _veterinarioRepository { get; set; }

        public VeterinariosController()
        {
            _veterinarioRepository = new VeterinarioRepository();
        }

        [Authorize(Roles = "1")]
        [HttpGet]

        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_veterinarioRepository.ListarTodos());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpGet("{idVeterinario}")]

        public IActionResult BuscarPorId(int idVeterinario)
        {
            try
            {
                return Ok(_veterinarioRepository.BuscarPorId(idVeterinario));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]

        public IActionResult Cadastrar(Veterinario novoVeterinario)
        {
            try
            {
                _veterinarioRepository.Cadastrar(novoVeterinario);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{idVeterinario}")]

        public IActionResult Atualizar(int idVeterinario, Veterinario novoVeterinario)
        {
            try
            {
                _veterinarioRepository.Atualizar(idVeterinario, novoVeterinario);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{idVeterinario}")]

        public IActionResult Deletar(int idVeterinario)
        {
            try
            {
                _veterinarioRepository.Deletar(idVeterinario);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

    }
}
