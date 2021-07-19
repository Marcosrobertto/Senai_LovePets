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
    public class TiposPetController : ControllerBase
    {

        private ITipoPetRepository _tipoPetRepository { get; set; }

        public TiposPetController()
        {
            _tipoPetRepository = new TipoPetRepository();
        }

        [HttpGet]

        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_tipoPetRepository.ListarTodos());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpGet("{idTipoPet}")]
        public IActionResult BuscarPorId(int idTipoPet)
        {
            try
            {
                return Ok(_tipoPetRepository.BuscarPorId(idTipoPet));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(TipoPet novoTipoPet)
        {
            try
            {
                _tipoPetRepository.Cadastrar(novoTipoPet);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPut("{idTipoPet}")]
        public IActionResult Atualizar(int idTipoPet, TipoPet novoTipoPet)
        {
            try
            {
                _tipoPetRepository.Atualizar(idTipoPet, novoTipoPet);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpDelete("{idTipoPet}")]
        public IActionResult Deletar(int idTipoPet)
        {
            try
            {
                _tipoPetRepository.Deletar(idTipoPet);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

    }
}
