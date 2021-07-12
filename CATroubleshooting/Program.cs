using System;

namespace CATroubleshooting
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = ConvertCelsiusToFehrenhite(0);
            Console.WriteLine($"{0}C = {f}F");

            var c = ConvertFehrenhiteToCelsius(32);
            Console.WriteLine($"{32}F = {c}C");

            Console.ReadKey();
        } 
         
        static decimal ConvertCelsiusToFehrenhite(decimal celsius)
        {
            var fehrenhite = 0m;
            fehrenhite = (celsius * 9 / 5) + 32;
            return fehrenhite;
        }

        static decimal ConvertFehrenhiteToCelsius(decimal fehrenhite)
        {
            var celsius = 0m;
            celsius = (fehrenhite - 32) * 5 /9;
            return celsius;
        }
    }
}
