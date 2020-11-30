using BlogEstudos.Model.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Controllers
{
    [Route("api")]
    [ApiController]
    public class ArquivosController : ControllerBase
    {
        private readonly ArquivosService _arquivosService;

        public ArquivosController(ArquivosService arquivosService)
        {
            _arquivosService = arquivosService;
        }

        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> UploadAsync([FromForm] IFormFile files, int materiaId)
        {
            try
            {
                var result = await _arquivosService.UploadAsync(files, materiaId);

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
