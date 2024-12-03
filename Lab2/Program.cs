namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temprature;
            double windSpeeds;
            double wct;
            bool hasWindSpeed = false;
            bool hasTemprature = false;

            bool menu = true;
            while (menu)
            {
                Console.WriteLine("\tWind Chill Calculator - Please enter the wind speed and temprature:" +
                    "\n\n\t[1] Wind Speed\n\t[2] Temprature\n\t[3] Exit Program");
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
                            bool subMenu = true;
                            while (subMenu)
                            {
                                Console.Clear();
                                Console.Write("Enter a temprature in Celcius:");
                                Double.TryParse(Console.ReadLine(), out temprature);
                                if (temprature is Double)
                                {
                                    hasTemprature |= true;
                                    subMenu = false;
                                }
                                else
                                {
                                    Console.WriteLine("This is not a temprature!");
                                    Console.ReadLine();
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
            static void WCTCaalculation(double temprature, double windSpeed)
            {
                //Ta in km/h från användaren ska kunna omvandla till m/s om nödväntigt
                //utifrån det ska vi beräkna windchill och utifrån det så ska vi
                //ska vi kunna placera det på windchill indexet
                double T = 2;
                double V = 3.3;
                double P = Math.Pow(windSpeed, 0.16);
                double wtc = 13.12 + 0.6215 * temprature - 11.37 * P + 0.3965 * temprature * P;
                Console.WriteLine(wtc);

            }
        }
        static void WindSpeed()
        {      
        }
    }
}

