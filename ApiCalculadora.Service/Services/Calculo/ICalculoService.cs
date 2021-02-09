namespace ApiCalculadora.Application.Calculo
{
    public interface ICalculoService
    {
        double KmLitro(double KmPorGas, double KmPorEtanol, double valorGas);
        double KmLitroGas(double valorGas);
        string MelhorCombustivel(double valorDoCalculo, double valorEtanol);
    }
}