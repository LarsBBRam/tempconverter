using Microsoft.VisualBasic;

namespace tempconverter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my handy temperature converter. Here you can convert Celsius, Kelvin, or Fahrenheit to the other.");
        Console.WriteLine("Please enter k for Kelvin, c for Celsius, or f for Fahrenheit");
        string? userInput = Console.ReadLine();
        if (userInput.ToLower().Trim().Contains("c"))
        {
            Console.WriteLine("Celsius chosen, what do you want to convert it to? Once again, enter k or f.");
            string? userInputC = Console.ReadLine();
            if (userInputC.ToLower().Trim().Contains("f"))
            {

                Console.WriteLine("Celsius to Fahrenheit chosen. How many degrees of Celsius? Only in numbers please.");
                string celsiusTemperature = Console.ReadLine();
                // double celsiusTemperature2 = Convert.ToDouble(celsiusTemperature);
                // bool isDouble = Double.TryParse(celsiusTemperature.Text out )
                if (double.TryParse(celsiusTemperature, out double convertedC))
                {
                    double celsiusToFahrenheit = convertedC * (1.8) + 32;
                    Console.WriteLine($"{celsiusTemperature} degrees Celsius is {celsiusToFahrenheit} degrees Fahrenheit.");

                }
                else
                {
                    Console.WriteLine("Write a proper number please.");
                }
            }
            else if (userInputC.ToLower().Trim().Contains("k"))
            {
                Console.WriteLine("Celsius to Kelvin chosen. How many degrees of Celsius? Only in numbers please");
                string celsiusTemperature2 = Console.ReadLine();
                if (double.TryParse(celsiusTemperature2, out double convertedC2))
                {
                    double celsiusToKelvin = convertedC2 + 273.15;
                    Console.WriteLine($"{celsiusTemperature2} degrees Celsius is {celsiusToKelvin} degrees Kelvin.");
                }
                else
                {
                    Console.WriteLine("Write a proper number please.");
                }
            }
            else
            {
                Console.WriteLine("Enter either k or f.");
            }
        }

        else if (userInput.ToLower().Trim().Contains("f"))
        {
            Console.WriteLine("Fahrenheit chosen, what do you want to convert it to? Once again, enter k or c.");
            string? userInputF = Console.ReadLine();
            if (userInputF.ToLower().Trim().Contains("c"))
            {
                Console.WriteLine("Fahrenheit to Celsius chosen. How many degrees of Fahrenheit? Only in numbers please.");
                string fahrenheitTemperature = Console.ReadLine();
                if (double.TryParse(fahrenheitTemperature, out double convertedF))
                {
                    double fahrenheitToCelsius = ((convertedF) - 32) / 1.8;
                    Console.WriteLine($"{fahrenheitTemperature} degrees Fahrenheit is {fahrenheitToCelsius} degrees celsius");

                }
            }
            else if (userInputF.ToLower().Trim().Contains("k"))
            {
                Console.WriteLine("Fahrenheit to Kelvin chosen. How many degrees of Fahrenheit? Only in numbers please.");
                string fahrenheitTemperature2 = Console.ReadLine();
                if (double.TryParse(fahrenheitTemperature2, out double convertedF2))
                {
                    double fahrenheitToKelvin = ((((convertedF2) - 32) / 1.8) + 273.15);
                    Console.WriteLine($"{fahrenheitTemperature2} degrees Fahrenheit is {fahrenheitToKelvin} degrees Kelvin.");
                }
                else
                {
                    Console.WriteLine("enter a proper number please.");
                }
            }
            else
            {
                Console.WriteLine("enter only c or k.");
            }
        }
        else if (userInput.ToLower().Trim().Contains("k"))
        {
            Console.WriteLine("Kelvin chosen, what do you want to convert it to? Once again, enter c or f.");
            string? userInputK = Console.ReadLine();
            if (userInputK.ToLower().Trim().Contains("c"))
            {
                Console.WriteLine("Kelvin to Celsius chosen. How much Kelvin? only in numbers please.");
                string kelvinTemperatures = Console.ReadLine();
                if (double.TryParse(kelvinTemperatures, out double convertedK))
                {
                    double kelvinToCelsius = (convertedK - 273.15);
                    Console.WriteLine($"{kelvinTemperatures} Kelvin is {kelvinToCelsius} degrees Celsius");
                }
                else
                {
                    Console.WriteLine("enter a proper number please.");
                }
            }
            else if (userInputK.ToLower().Trim().Contains("f"))
            {
                Console.WriteLine("Kelvin to Fahrenheit chosen. How much Kelvin? only in numbers please.");
                string kelvinTemperatures2 = Console.ReadLine();
                if (double.TryParse(kelvinTemperatures2, out double convertedK2))
                {
                    double kelvinToFahrenheit = ((((convertedK2) - 273.15) / (9 / 5)) + 32);
                    Console.WriteLine($"{kelvinTemperatures2} Kelvin is {kelvinToFahrenheit} degrees Fahrenheit.");
                }
                else
                {
                    Console.WriteLine("enter a proper number please.");
                }
            }
            else
            {
                Console.WriteLine("Write either f or c, nothing else.");
            }

        }
        else
        {
            Console.WriteLine("Write either f, c or k, nothing else.");

        }


        // double fahrenheitToCelsius = fahrenheitTemperature / (1.8) - 32;


    }
}
