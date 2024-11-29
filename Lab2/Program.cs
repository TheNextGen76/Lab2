namespace Lab2
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
                Console.WriteLine("\tWind Chill Calculator\n\n\t[1] Beräkna Windchill faktorn i Km/h #1\n\t[2] Beräkna windchill faktron i m/s #2\n\t[3] Exit Program");
                Int32.TryParse(Console.ReadLine(), out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Case 1");

                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Case 2");
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
            static void WCTCaalculation()
            {
                //Ta in km/h från användaren ska kunna omvandla till m/s om nödväntigt
                //utifrån det ska vi beräkna windchill och utifrån det så ska vi
                //ska vi kunna placera det på windchill indexet
                double T;
                double V;
                double wtc = 13.12 + 0.6215 * T - 11.37 * V ^ 0.16 + 0.3965 * T * V ^ 0.16;

            }
        }
    }
}

