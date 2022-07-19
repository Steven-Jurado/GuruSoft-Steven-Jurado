using Laboratorio.Helpers;
using Laboratorio.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Mime;

namespace Laboratorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorMaper _calculatorMaper;
        public CalculatorController(ICalculatorMaper calculatorMaper)
        {
            _calculatorMaper = calculatorMaper;
        }

        [HttpPost]
        [Route("numberprimo")]
        public IActionResult CalculatorNumberPrimo([FromQuery] CalculatorPrimoRequest calculatorPrimoRequest)
        {

            try
            {
                if (calculatorPrimoRequest.EndNumber <= calculatorPrimoRequest.StartNumber)
                    return BadRequest("Numero Final debe Ser Mayor Al Numero de Inicio");


                var responseCalculator = _calculatorMaper.NumberPrimoRange(calculatorPrimoRequest.StartNumber, calculatorPrimoRequest.EndNumber);

                return Ok(new { listNumberPrimo = responseCalculator });
            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.Message);
            }

            
        }
    }
}
