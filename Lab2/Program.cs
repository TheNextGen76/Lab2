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
                Console.WriteLine("\tWind Chill Calculator\n\n\t[1] Stuff #1\n\t[2] Stuff #2\n\t[3] Exit Program");
                Int32.TryParse(Console.ReadLine(), out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
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

            }
        }
    }
}

