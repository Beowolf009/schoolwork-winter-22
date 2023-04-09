using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = FahrenheitToCelsius(fahrenheit);
        double kelvin = FahrenheitToKelvin(fahrenheit);

        Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C and {kelvin}K");
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        return celsius;
    }

    static double FahrenheitToKelvin(double fahrenheit)
    {
        double kelvin = (fahrenheit + 459.67) * 5 / 9;
        return kelvin;
    }
}
