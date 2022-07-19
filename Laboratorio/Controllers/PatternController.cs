using Laboratorio.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Mime;

namespace Laboratorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
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

                var responsePattern = _patternMaper.FindPattern(pattern);

                return Ok(responsePattern);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
