﻿namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temprature;
            double windSpeeds;
            double wct;

            bool menu = true;
            while (menu)
            {
                WCTCaalculation();
                Console.WriteLine("\tWind Chill Calculator\n\n\t[1] Beräkna Windchill faktorn\n\t[2] Exit Program");
                Int32.TryParse(Console.ReadLine(), out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("");

                            break;
                        }
                    case 2:
                        {
                            menu = false;
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }


            }
            static void WCTCaalculation()
            {
                //Ta in km/h från användaren ska kunna omvandla till m/s om nödväntigt
                //utifrån det ska vi beräkna windchill och utifrån det så ska vi
                //ska vi kunna placera det på windchill indexet
                double T = 2;
                double V = 3.3;
                double P = Math.Pow(V, 0.16);
                double wtc = 13.12 + 0.6215 * T - 11.37 * P + 0.3965 * T * P;
                Console.WriteLine(wtc);

            }
        }
        static void WindSpeed()
        {
            bool loop = true;
            while (loop)
            {
                try 
                {
                    Double.TryParse(Console.ReadLine(), out int userInput);
                    
                }
                catch
                {

                }
            }

        }
    }
}

