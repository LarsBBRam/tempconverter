using Microsoft.VisualBasic;

namespace tempconverter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Would you like to convert from Celsius or Fahrenheit? Please answer by putting C or F");
        string? userInput = Console.ReadLine();
        if (userInput.ToLower().Trim().Contains("f"))
        {
            Console.WriteLine("Celsius to Fahrenheit chosen. How many degrees of Celsius? Only in numbers please.");
            string celsiusTemperature = Console.ReadLine();
            double celsiusTemperature2 = Convert.ToDouble(celsiusTemperature);
            // bool isDouble = Double.TryParse(celsiusTemperature.Text out )
            if (celsiusTemperature2 == Type.double) ;
            {
                double celsiusToFahrenheit = (double)celsiusTemperature * (1.8) + 32;
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
            double? fahrenheitTemperature = Console.Read();
            // if (fahrenheitTemperature = )
        }
        else
        {
            Console.WriteLine("Write either f or c, nothing else.");
        }


        // double fahrenheitToCelsius = fahrenheitTemperature / (1.8) - 32;


    }
}
