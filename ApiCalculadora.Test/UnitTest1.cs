using ApiCalculadora.Application.Calculo;
using NUnit.Framework;

namespace ApiCalculadora.Test
{
    public class CalculadoraTest
    {
        private readonly double kmPorGas = 10;
        private readonly double kmPorEtanol = 7.3;
        private readonly double valorGas = 4.259;
        private readonly double valorEtanol = 3.039;
        private CalculoService service;

        [SetUp]
        public void Setup()
        {
            service = new CalculoService();
        }

        [Test]
        public void KmPorLitro()
        {
            var resultado = service.KmLitro(kmPorGas, kmPorEtanol, valorGas);

            const double esperado = 3.10907;
            Assert.AreEqual(esperado, resultado, $"O resultado experado era: {esperado} porém o retorno foi: {resultado}");
        }

        [Test]
        public void KmGasolina()
        {
            var resultado = service.KmLitroGas(valorGas);

            const double esperado = 2.9813;
            Assert.AreEqual(esperado, resultado, $"O resultado experado era: {esperado} porém o retorno foi: {resultado}");
        }
    }
}