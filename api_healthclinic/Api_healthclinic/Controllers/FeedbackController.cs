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
    public class FeedbackController : ControllerBase
    {
        private IFeedbackRepository _feedbackRepository;

        public FeedbackController()
        {
            _feedbackRepository = new FeedbackRepository();
        }

        /// <summary>
        /// End Point que aciona o método de Listar os comentários.
        /// </summary>
        /// <returns>Lista</returns>

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_feedbackRepository.Listar());

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
        public IActionResult Post(Feedback novoComentario)
        {
            try
            {
                _feedbackRepository.Comentar(novoComentario);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// End Point que aciona o método(Atualizar) para editar um comentário.
        /// </summary>
        /// <returns>Comentário atualizado</returns>

        [HttpPatch]
        public IActionResult Patch(Guid id, Feedback comentario)
        {
            try
            {
                _feedbackRepository.Atualizar(id, comentario);
                return StatusCode(200, comentario);

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
                _feedbackRepository.Deletar(id);
                return StatusCode(200);

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}
