using BlogEstudos.Data;
using BlogEstudos.Model;
using BlogEstudos.Model.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Controllers
{
    [Route("api")]
    [ApiController]
    public class PublicacaoController : ControllerBase
    {
        private readonly PublicacaoService _publicacaoService;

        public PublicacaoController(PublicacaoService publicacaoService)
        {
            _publicacaoService = publicacaoService;
        }

        [HttpGet]
        [Route("GetPublicacoes")]
        public async Task<IActionResult> GetPublicacoes(int usuarioId)
        {
            try
            {
                var publicacoes = await _publicacaoService.SelectAllPublicacoes(usuarioId);

                return Ok(publicacoes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPost]
        [Route("PostPublicacao")]
        public async Task<IActionResult> PostPublicacao([FromBody] Publicacao publicacao)
        {
            try
            {
                await _publicacaoService.CriarPublicaoAsync(publicacao);

                return Ok("Inserido com sucesso");
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
