using CdbCalculatorApp.Server.Service;
using Xunit;

namespace CdbCalculatorApp.Tests;

public class CdbCalculatorServiceTests
{
    private readonly CalculadoraService _service = new();

    [Theory]
    [InlineData(1000, 6)]
    [InlineData(2000, 12)]
    [InlineData(500, 25)]
    public void Calcular_DeveRetornarBrutoELiquido(decimal valorInicial, int prazo)
    {
        var resultado = _service.CalcularRetorno(valorInicial, prazo);
        Assert.True(resultado.ValorBruto > 0);
        Assert.True(resultado.ValorLiquido > 0);
        Assert.True(resultado.ValorLiquido < resultado.ValorBruto);
    }

    [Theory]
    [InlineData(-1, 10)]
    [InlineData(0, 10)]
    public void Calcular_DeveLancarExcecao_ValorInicialInvalido(decimal valorInicial, int prazo)
    {
        Assert.Throws<ArgumentException>(() => _service.CalcularRetorno(valorInicial, prazo));
    }

    [Theory]
    [InlineData(1000, 0)]
    [InlineData(1000, -5)]
    public void Calcular_DeveLancarExcecao_PrazoInvalido(decimal valorInicial, int prazo)
    {
        Assert.Throws<ArgumentException>(() => _service.CalcularRetorno(valorInicial, prazo));
    }

    [Theory]
    [InlineData(3, 0.225)]
    [InlineData(6, 0.225)]
    [InlineData(9, 0.20)]
    [InlineData(18, 0.175)]
    [InlineData(30, 0.15)]
    public void GetAliquota_DeveRetornarValorEsperado(int meses, double esperado)
    {
        var resultado = CalculadoraService.GetAliquota(meses); // Fixed by qualifying with the type name
        Assert.Equal((decimal)esperado, resultado);
    }
}
