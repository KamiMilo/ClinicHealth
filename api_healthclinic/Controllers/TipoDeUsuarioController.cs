using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;
using Api_healthclinic.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Api_healthclinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoDeUsuarioController : ControllerBase
    {

            private ITipoDeUsuarioRepository _tipoDeUsuarioRepository;

            public TipoDeUsuarioController()
            {
                _tipoDeUsuarioRepository = new TipoDeUsuarioRepository();
            }

            /// <summary>
            /// End Point para cadastrar um novo tipo de usuario.
            /// </summary>
            /// <param name="tiposUsuario"></param>
            /// <returns></returns>

            [HttpPost]
            public IActionResult Post(TipoUsuario tipoUsuario)
            {
                try
                {
                    _tipoDeUsuarioRepository.Cadastrar(tipoUsuario);
                    return StatusCode(201);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            /// <summary>
            /// End Point que lista os Tipos de Usuario cadastrados
            /// </summary>
            /// <returns>Lista</returns>
            [HttpGet]
            public IActionResult Get()
            {
                try
                {
                    return Ok(_tipoDeUsuarioRepository.Listar());

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

        [HttpDelete("{id}")]
            public IActionResult Delete(Guid id)
            {
                try
                {
                    _tipoDeUsuarioRepository.Deletar(id);

                    return Ok(200);

                }

                catch (Exception e)
                {
                    return BadRequest(e.Message);

                }
            }


     }
 }

