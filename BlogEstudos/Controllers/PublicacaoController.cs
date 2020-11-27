using BlogEstudos.Data;
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
        private readonly DataContext _context;

        public PublicacaoController(DataContext context)
        {
            _context = context;
        } 

        [HttpGet]
        [Route("GetPublicacoes")]
        public async Task<IActionResult> GetPublicacoes()
        {
            var publicacoes = await _context.Publicacoes.Where(x => x.Id > 0).ToListAsync();

            return Ok(publicacoes);
        }



    }
}
