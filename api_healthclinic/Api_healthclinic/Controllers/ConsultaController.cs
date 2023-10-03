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
    public class ConsultaController : ControllerBase
    {
        private IConsultaRepository _ConsultaRepository;

        public ConsultaController()
        {
            _ConsultaRepository = new ConsultaRepository();
        }
        /// <summary>
        /// End Point que aciona o método de Listar todas as Consultas.
        /// </summary>
        /// <returns>Lista</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(_ConsultaRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// End Point que aciona o método de Cadastrar.
        /// </summary>
        /// <returns>Consulta</returns>

        [HttpPost]
        public IActionResult Post(Consulta novaConsulta)
        {
            try
            {
                _ConsultaRepository.Cadastrar(novaConsulta);
                return StatusCode(201, novaConsulta);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// End Point que aciona o método(Atualizar) para editar uma consulta.
        /// </summary>
        /// <returns>Consulta Atualizada</returns>
        [HttpPatch]
        public IActionResult pacth(Consulta consulta, Guid id)
        {
            try
            {
                _ConsultaRepository.Atualizar(id, consulta);
                return Ok(consulta);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// End Point que aciona o método para buscar consulta pelo Id do Médico.
        /// </summary>
        /// <returns>Lista</returns>
        [HttpGet("{id}")]
        public IActionResult GetByMedico(Guid id)
        {
            try
            {
                return Ok(_ConsultaRepository.ListarMedico(id));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// End Point que aciona o método para buscar consulta pelo Id do Paciente.
        /// </summary>
        /// <returns>Lista </returns>
        [HttpGet("{id}")]
        public IActionResult GetByPaciente(Guid id)
        {
            try
            {
                return Ok(_ConsultaRepository.ListarPaciente(id));

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
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _ConsultaRepository.Deletar(id);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

