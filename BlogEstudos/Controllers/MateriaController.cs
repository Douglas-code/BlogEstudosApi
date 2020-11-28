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
    public class MateriaController : ControllerBase
    {
        private readonly MateriaService _materiaService;

        public MateriaController(MateriaService materiaService)
        {
            _materiaService = materiaService;
        }

        [HttpGet]
        [Route("GetMaterias")]
        public async Task<IActionResult> GetMateriasAsync()
        {
            try
            {
                var materias = await _materiaService.SelectAllMateriasAsync();

                return Ok(materias);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
