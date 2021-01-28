using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCalculadora.Services;

namespace ApiCalculadora.Controllers
{
    public class CalculoController
    {
        private readonly CalculoService _CalculoService;
        public void RecebeValores (double KmPorGas, double KmPorEtanol, double valorGas, double valorEtanol)
        {
            double resultadoDouble = _CalculoService.KmLitro(KmPorGas, KmPorEtanol, valorGas);
            string resultadoString = _CalculoService.retornoFrase(resultadoDouble, valorEtanol);
        }
    }
}
