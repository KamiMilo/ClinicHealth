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
    public class EspecilidadeController : ControllerBase
    {
        private IEspecialidadeRepository _especialidadeRepository;

        public EspecilidadeController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }
        /// <summary>
        /// End Point que aciona o método de Listar as Especialidades.
        /// </summary>
        /// <returns>Lista</returns>

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(_especialidadeRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// End Point que aciona o método de Cadastrar.
        /// </summary>
        /// <returns>Especialidade</returns>

        [HttpPost]
        public IActionResult Post(Especialidade novaEspecialidade)
        {
            try
            {
                _especialidadeRepository.Cadastrar(novaEspecialidade);
                return StatusCode(201, novaEspecialidade);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// End Point que aciona o método de (atualizar) editar uma especialidade.
        /// </summary>
        /// <returns>Especialidade atualizada</returns>

        [HttpPatch]
        public IActionResult pacth(Especialidade especialidade, Guid id)
        {
            try
            {
                _especialidadeRepository.Atualizar(id, especialidade);
                return Ok(especialidade);
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
        public IActionResult Delete(Guid id)
        {
            try
            {
                _especialidadeRepository.Deletar(id);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
