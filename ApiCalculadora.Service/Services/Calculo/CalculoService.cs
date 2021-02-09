using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculadora.Application.Calculo
{
    public class CalculoService : ICalculoService
    {
        public double KmLitro(double KmPorGas, double KmPorEtanol, double valorGas)
        {
            double divKms = KmPorEtanol / KmPorGas;
            double valorDoCalculo = divKms * valorGas;
            return valorDoCalculo;
        }

        public double KmLitroGas(double valorGas)
        {
            double valorDoCalculo = valorGas * 0.7;
            return valorDoCalculo;
        }

        public string MelhorCombustivel(double valorDoCalculo, double valorEtanol)
        {
            if (valorEtanol <= valorDoCalculo)
                return "Compensa abastecer com o Etanol";
            else
                return "Compensa abastecer com a Gasolina";
        }
    }
}
