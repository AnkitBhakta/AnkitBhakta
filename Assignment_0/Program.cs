using System;

namespace Assignment_0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press 1 to convert from Fahrenheit to Celsius");
            Console.WriteLine("Press 2 to convert from Celsius to Fahrenheit?");
            Console.WriteLine("Press 3 to convert from Square Feet to Square Meters");
            Console.WriteLine("Press 4 to convert from Square Meters to Square Foot");
            Console.WriteLine("Press 5 to convert from Gallons to Liters");
            Console.WriteLine("Press 6 to convert from Liters to Gallons");
            Console.WriteLine("Press 7 to convert from Pounds to Kilograms");
            Console.WriteLine("Press 8 to convert from Kilograms to Pounds");

            int choice = Convert.ToInt32(Console.ReadLine());

            



            switch (choice)
            {
            //TEMPATURE
            case 1:
            Console.WriteLine("Enter your tempature in Celsius: ");
                int celsius = Convert.ToInt32(Console.ReadLine());
                int celsius_2 = celsius * 9/5 + 32;
            Console.WriteLine("The tempature in fahrenheit is " + celsius_2);
            break;

            case 2:
            Console.WriteLine("Enter your tempature in Fahrenheit: ");
                int fahrenheit = Convert.ToInt32(Console.ReadLine());
                double fahrenheit_2 = (fahrenheit - 32) * 5/9;
            Console.WriteLine("The tempature in Celsius is " + fahrenheit_2);
            break;

            case 3:
            //AREA
            Console.WriteLine("Enter squarefeet: ");
                double squarefoot = Convert.ToInt32(Console.ReadLine());
                double squarefoot_2 = squarefoot * 0.09290304;
            Console.WriteLine("Square Meters is " + squarefoot_2);
            break;

            case 4:
            Console.WriteLine("Enter Square Meter: ");
                double squaremeter = Convert.ToInt32(Console.ReadLine());
                double squaremeter_2 = squaremeter * 10.7639104167;
            Console.WriteLine("Square Feet is " + squaremeter_2);
            break;

            case 5:
            //VOLUME
            Console.WriteLine("Enter Gallons: ");
                int gallon = Convert.ToInt32(Console.ReadLine());
                double gallon_2 = gallon *  3.785411784;
            Console.WriteLine("Gallons to Liters is " + gallon_2);
            break;

            case 6:
            Console.WriteLine("Enter Liters: ");
                int liters = Convert.ToInt32(Console.ReadLine());
                double liters_2 = liters * 0.2641720524;
            Console.WriteLine("Liters to Gallons is " + liters_2);
            break;

            case 7:
            //Weight
            Console.WriteLine("Enter Pounds: ");
            int pounds = Convert.ToInt32(Console.ReadLine());
            double pounds_2 = pounds * .45359237;
            Console.WriteLine("Kilograms is " + pounds_2);
            break;

            case 8:
            Console.WriteLine("Enter Kilograms: ");
            int kilograms = Convert.ToInt32(Console.ReadLine());
            double kilograms_2 = kilograms * 2.2046226218;
            Console.WriteLine("Pounds is " + kilograms_2);
            break;

            }
        }
    }
}
