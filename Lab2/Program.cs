namespace Lab2
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
                            bool choiceMenu = true;
                            while (subMenu)
                            {
                                Console.WriteLine("\tChoose a speed!\n\n\t[1] km/h\n\t[2] m/s");
                                Int32.TryParse(Console.ReadLine(), out menuChoice);
                                switch (menuChoice)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            while (choiceMenu == true)
                                            {                                             
                                                Console.Write("\n\tkm/h: ");
                                                Double.TryParse(Console.ReadLine(), out windSpeeds);
                                                if (windSpeeds != 0)
                                                {
                                                    Console.Clear();
                                                    windSpeedsStr = " - " + windSpeeds.ToString() + "km/h";
                                                    hasWindSpeed = true;
                                                    subMenu = false;
                                                    choiceMenu = false;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\tThis is not a valid input! Please enter km/h.\n");
                                                }
                                            }
                         
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            while (choiceMenu)
                                            {
                                                Console.Write("\n\tm/s: ");
                                                Double.TryParse(Console.ReadLine(), out windSpeeds);
                                                if (windSpeeds != 0)
                                                {
                                                    double convertedSpeed = (windSpeeds * 3600) / 1000;
                                                    windSpeedsStr = " - " + convertedSpeed.ToString() + "m/s";
                                                    hasWindSpeed = true;
                                                    subMenu = false;
                                                    choiceMenu = false;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\tThis is not a valid input! Please enter m/s.\n");
                                                }
                                            }
                                           
                                            break;
                                        }
                                    default:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\tPlease choose a valid option\n");
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            bool subMenu = true;
                            bool choiceMenu = true;
                            
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
                                    Console.WriteLine("\tThis is not a valid input! Please enter a valid temprature.\n");
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

