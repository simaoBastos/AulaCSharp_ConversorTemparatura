using Xunit;
using ConversorTemperatura.App;
namespace ConversorTemperatura.Tests;
public class ConversorTemperaturaTests
{
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)]
    public void Celsius_ParaFahrenheit(double entrada, double esperado)
    {
        var servico = new ConversorTemperatura.App.ConversorTemperatura();
        Assert.Equal(esperado, servico.ParaFahrenheit(entrada), 6);
    }
    
    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    public void Fahrenheit_ParaCelsius(double entrada, double esperado)
    {
        var servico = new ConversorTemperatura.App.ConversorTemperatura();
        Assert.Equal(esperado, servico.ParaCelsius(entrada), 6);
    }
}