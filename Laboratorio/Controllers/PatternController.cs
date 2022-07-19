using Laboratorio.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatternController : ControllerBase
    {

        private readonly IPatternMaper _patternMaper;
        public PatternController(IPatternMaper patternMaper)
        {
            _patternMaper = patternMaper;
        }

        [HttpPost]
        [Route("pattern")]
        public IActionResult FinPattern([FromQuery] String pattern)
        {
            try
            {

                var jaja = _patternMaper.FindPattern(pattern);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
