using Api_healthclinic.Domains;
using Api_healthclinic.Interfaces;
using Api_healthclinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_healthclinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            //********CADASTRAR**************

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
            //*********Listar*******************

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

            [HttpDelete]
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

