using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCalculadora.Application;
using ApiCalculadora.Application.Calculo;
using ApiCalculadora.Application.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalculadora.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoController : Controller
    {
        private readonly ICalculoService _CalculoService;

        public CalculoController(ICalculoService calculoService)
        {
            _CalculoService = calculoService;
        }

        [HttpGet]
        [Route("CalculoCompleto")]
        public IActionResult CalculoCompleto(double KmPorGas, double KmPorEtanol, double valorGas, double valorEtanol)
        {
            var calculo = _CalculoService.KmLitro(KmPorGas, KmPorEtanol, valorGas);
            var result = new ResultadoCalculo()
            {
                Calculo = calculo,
                Mensagem = _CalculoService.MelhorCombustivel(calculo, valorEtanol)
            };

            return Ok(result);
        }

        [HttpGet]
        [Route("CalculoSemKmsRod")]
        public IActionResult CalculoSemkmsRod(double valorGas, double valorEtanol)
        {
            var calculo = _CalculoService.KmLitroGas(valorGas);
            var result = new ResultadoCalculo()
            {
                Calculo = calculo,
                Mensagem = _CalculoService.MelhorCombustivel(calculo, valorEtanol)
            };

            return Ok(result);
        }
    }
}
