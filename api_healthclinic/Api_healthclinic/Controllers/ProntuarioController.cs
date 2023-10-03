using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;
using Api_healthclinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_healthclinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProntuarioController : ControllerBase
    {
        private IProntuarioRepository _prontuarioRepository;

        public ProntuarioController()
        {
            _prontuarioRepository = new ProntuarioRepository();
        }
        /// <summary>
        /// End Point que aciona o método de listar.
        /// </summary>
        /// <returns>Lista</returns>

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_prontuarioRepository.Listar());

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

           /// <summary>
           /// End Point que aciona o método de Cadastrar.
           /// </summary>
           /// <returns></returns>
          [HttpPost]
          public IActionResult Post(Prontuario prontuario)
          {
            try
            {
                _prontuarioRepository.Cadastrar(prontuario);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        /// <summary>
        /// End Point que aciona o método de Buscar pelo id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_prontuarioRepository.BuscarporId(id));

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);

            }

        }

        /// <summary>
        /// End Point que aciona o método pra Deletar.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _prontuarioRepository.Delete(id);
                return StatusCode(200);

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }

}
