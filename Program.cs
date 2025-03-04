using Microsoft.VisualBasic;

namespace tempconverter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C for converting from celsius to Fahrenheit, and F for the opposite.");
        string? userInput = Console.ReadLine();
        if (userInput.ToLower().Trim().Contains("c"))
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
        else if (userInput.ToLower().Trim().Contains("f"))
        {
            Console.WriteLine("Fahrenheit to Celsius chosen. How many degrees of Fahrenheit? Only in numbers please.");
            string fahrenheitTemperature = Console.ReadLine();
            if (double.TryParse(fahrenheitTemperature, out double convertedF))
            {
                double fahrenheitToCelsius = ((convertedF) - 32) / 1.8;
                Console.WriteLine($"{fahrenheitTemperature} degrees Fahrenheit is {fahrenheitToCelsius} degrees celsius");
            }
            else
            {
                Console.WriteLine("Write a proper number please.");
            }
        }
        else
        {
            Console.WriteLine("Write either f or c, nothing else.");
            return;
        }


        // double fahrenheitToCelsius = fahrenheitTemperature / (1.8) - 32;


    }
}
