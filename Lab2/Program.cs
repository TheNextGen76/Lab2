﻿namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temprature = 0;
            string tempratureStr = "";
            double windSpeeds = 0;
            string windSpeedsStr = "";
            double wct;
            string wctIndexStr = "";
            bool hasWindSpeed = false;
            bool hasTemprature = false;
            bool menu = true;
            while (menu)
            {
                if (hasWindSpeed == true && hasTemprature == true) 
                {
                    wct = WCTCalculation(temprature,windSpeeds);
                    if (wct > -25) 
                    {
                        wctIndexStr = $"\tThe Wind Chill is {wct}°C which is - Cold";
                    }
                    else if (wct <= -25 && wct > -35)
                    {
                        wctIndexStr = $"\tThe Wind Chill is {wct}°C which is - Very Cold";
                    }
                    else if (wct <= -35 && wct > -60)
                    {
                        wctIndexStr = $"\tThe Wind Chill is {wct}°C which is - Danger of Frostbite";
                    }
                    else if (wct < -60)
                    {
                        wctIndexStr = $"\tThe Wind Chill is {wct}°C which is - Great Danger of Frostbite";
                    }
                    Console.WriteLine(wctIndexStr);
                }
                else
                {
                    Console.WriteLine($"\tWind Chill Calculator - Please enter the wind speed and temprature:");
                }
                    Console.WriteLine($"\n\t[1] Wind Speed {windSpeedsStr}\n\t[2] Temprature {tempratureStr}\n\n\t[3] Exit Program");
                Int32.TryParse(Console.ReadLine(), out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        {
                            Console.Clear();
                            bool subMenu = true;
                            while (subMenu)
                            {
                                Console.Write("\tChoose a speed km/h or m/s:");
                                string input = Console.ReadLine().ToLower(); 
                                if (input == "km/h")
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tWrite speed\n");
                                    Double.TryParse(Console.ReadLine(), out windSpeeds);
                                    if (windSpeeds != 0)
                                    {
                                        Console.Clear();
                                        windSpeedsStr = " - " + windSpeeds.ToString();
                                        hasWindSpeed = true;
                                        subMenu = false;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\tThis is not a WindSpeed! Please enter valid Wind Speed.\n");
                                    }

                                }
                                else if (input == "m/s")
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tWrite Speed\n");
                                    Int32.TryParse(Console.ReadLine, out int userInput);
                                    int convertMeters = (userInput * 3600) / 1000;
                                    windSpeedsStr = " - " + convertMeters.ToString();
                                    hasWindSpeed = true;
                                    subMenu = false;
                                    

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tthis is not km/h or m/s, please enter a valid syntax.\n");

                                }
                                
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            bool subMenu = true;
                            while (subMenu)
                            {
                                Console.Write("\tEnter a temprature in Celcius:");
                                Double.TryParse(Console.ReadLine(), out temprature);
                                if (temprature != 0)
                                {
                                    Console.Clear();
                                    tempratureStr = " - " + temprature.ToString() + "°C ";
                                    hasTemprature = true;
                                    subMenu = false;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("\tThis is not a temprature! Please enter a valid temprature.\n");
                                }
                            }
                            break;
                           
                        }
                    case 3:
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
            static double WCTCalculation(double temprature, double windSpeed)
            {
                //Ta in km/h från användaren ska kunna omvandla till m/s om nödväntigt
                //utifrån det ska vi beräkna windchill och utifrån det så ska vi
                //ska vi kunna placera det på windchill indexet
                double P = Math.Pow(windSpeed, 0.16);
                double wtc = 13.12 + 0.6215 * temprature - 11.37 * P + 0.3965 * temprature * P;
                wtc = Math.Round(wtc,2);
                return wtc;

            }
        }
    }
}

