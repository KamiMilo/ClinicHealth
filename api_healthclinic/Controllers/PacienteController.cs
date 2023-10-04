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
    public class PacienteController : ControllerBase
    {

        private IPacienteRepository _pacienteRepository;

        public PacienteController()
        {
            _pacienteRepository = new PacienteRepository();
        }

        /// <summary>
        /// End Point que aciona o método de Listar os Pacientes.
        /// </summary>
        /// <returns>Lista</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_pacienteRepository.Listar());

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        /// <summary>
        /// End Point que aciona o método de Cadastrar.
        /// </summary>
        /// <returns>Ok</returns>
        [HttpPost]
        public IActionResult Post(Paciente paciente)
        {
            try
            {
                _pacienteRepository.Cadastrar(paciente);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// End Point que aciona o método Atualizar.
        /// </summary>
        /// <returns>Paciente atualizado</returns>
        [HttpPatch]
        public IActionResult Patch(Guid id, Paciente paciente)
        {
            try
            {
                _pacienteRepository.Atualizar(id, paciente);
                return StatusCode(200, paciente);

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
                _pacienteRepository.Deletar(id);
                return StatusCode(200);

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}
