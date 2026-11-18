namespace ConversorTemperatura.App;
public class ConversorTemperatura
{
    public double ParaFahrenheit(double celsius) => celsius * 9 / 5 + 32;
    public double ParaCelsius(double fahrenreit) => (fahrenreit - 32) * 5 / 9;
}