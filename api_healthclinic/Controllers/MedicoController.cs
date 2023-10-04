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
    public class MedicoController : ControllerBase
    {
        private IMedicoRepository _medicoRepository;

        public MedicoController()
        {
            _medicoRepository = new MedicoRepository();
        }

        /// <summary>
        /// End Point que aciona o método de Cadastrar.
        /// </summary>
        /// <returns>Ok</returns>
        [HttpPost]
        public IActionResult Post(Medico medico)
        {
            try
            {
                _medicoRepository.Cadastrar(medico);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// End Point que aciona o método de Listar os médicos.
        /// </summary>
        /// <returns>Lista</returns>

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_medicoRepository.Listar());

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);

            }

        }
        /// <summary>
        /// End Point que aciona o método Atualizar.
        /// </summary>
        /// <returns>Médico atualizado</returns>
        [HttpPatch]
            public IActionResult Patch(Guid id, Medico medico)
            {
                try
                {
                    _medicoRepository.Atualizar(id, medico);
                    return StatusCode(200, medico);

                }

                catch (Exception e)
                {
                    return BadRequest(e.Message);

                }
            }
        /// <summary>
        /// End Point que aciona o método pra Deletar.
        /// </summary>
        /// <returns>Ok</returns>

        [HttpDelete]
         public IActionResult Delete(Guid id )
         {
            try
            {
                _medicoRepository.Deletar(id);
                return StatusCode(200);

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}
