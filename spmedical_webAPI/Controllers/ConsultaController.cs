using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using spmedical_webAPI.Domains;
using spmedical_webAPI.Interfaces;
using spmedical_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {

        private IConsultaRepository _consultaRepository { get; set; }

        public ConsultaController() 
        {
            _consultaRepository = new ConsultaRepository();
        }

        [Authorize(Roles = "2")]
        [HttpGet("minhas")]

        public IActionResult ListarMinhas() 
        {
            try 
            {
                int idUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

                return Ok(_consultaRepository.ListarMinhas(idUsuario));
            }
            catch (Exception error)
            {
                return BadRequest(new
                {
                    mensagem = "Não é possivel mostrar as consultas se o usuário não estiver logado!", error
                });
                    
            }
        }

        [Authorize(Roles = "2")]
        [HttpPost("Inserir")]

        public IActionResult Inscrever(Consulta consulta) 
        {
            try
            {
                consulta.IdUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                

                _consultaRepository.Inscrever(consulta);

                return StatusCode(201);

            }
            catch (Exception error)
            {

                return BadRequest(new
                {
                    mensagem = "Não é possivel marcar uma consulta se o usuario nao estiver logado!", error
                });
            }
        }


    }
}
