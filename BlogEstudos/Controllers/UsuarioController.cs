using BlogEstudos.Model;
using BlogEstudos.Model.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Controllers
{
    [Route("api")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("CriarConta")]
        public async Task<IActionResult> PostUsuarioAsync([FromBody] Usuario usuario)
        {
            try
            {
                await _usuarioService.InsertUsuarioAsync(usuario);

                return Ok("Inserido com Sucesso");
            }
            catch(Exception e) 
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] Usuario usu)
        {
            try
            {
                var usuario = await _usuarioService.Login(usu.Login, usu.Senha);

                return Ok(usuario);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
