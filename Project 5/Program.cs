using System;

namespace Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("--- Main Menu ---");
                Console.WriteLine("1. Bank Program");
                Console.WriteLine("2. Parking Garage Cost");
                Console.WriteLine("3. Hurricane");
                Console.WriteLine("");
                Console.WriteLine("Choose what program to run (1-3): ");
                string choice = Console.ReadLine(); 

                switch (choice)
                {

                    case "1":
                        BankProgram();
                        break;

                    case "2":
                        ParkingGarage();
                        break;

                    case "3":
                        RunHurricane();
                        break;

                    default:
                        Console.WriteLine();
                        break;
                        
                }
            }
     
        }
        private static void BankProgram()
        {
            Random rnd = new Random();
            double bankAccount = rnd.Next(100, 151);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-- WELCOME TO THE BANK --");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Current balance in your bank account: ${0}", bankAccount);
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Enter transaction type (deposit, withdrawal, bill payment, or balance update): ");
            string transactionType = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter transaction amount: ");
            double transactionAmount = double.Parse(Console.ReadLine());

            switch(transactionType)
            {
                case "deposit":
                    bankAccount += transactionAmount;
                    break;
                    
                    
                case "withdrawal":
                    if (transactionAmount + 0.75 <= bankAccount)
                    {
                        bankAccount -= transactionAmount + 0.75;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not enough funds");
                        Console.ResetColor();
                    }
                    break;

                case "bill payment":
                    if (transactionAmount + 0.75 <= bankAccount)
                    {
                        bankAccount -= transactionAmount + 0.75;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not enough funds");
                        Console.ResetColor();
                    }
                    break;

                case "balance update":
                    bankAccount = transactionAmount + 0.75;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid transaction type");
                    Console.ResetColor();
                    break;

            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You now have ${0} in your your bank account.", bankAccount);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void ParkingGarage()
        {
            double minFee = 4.0;
            double hourlyRate = 2.0;
            double maxCharge = 20.0;

            Console.Write("Enter the number of minutes parked in garage: ");
            int minutes = int.Parse(Console.ReadLine());

            if (minutes <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invaild");
                Console.ResetColor();
                return;
            }

            int hours = (int)Math.Ceiling(minutes / 60.0);

            double cost = minFee + (hours - 1) * hourlyRate;

            Console.WriteLine("Hours parked: {0}", hours);
            Console.WriteLine("Cost: {0:C}", cost);


        }

        public static void RunHurricane()
        {
            Console.WriteLine();
            Console.WriteLine("-- Saffir-Simpson Hurricane Scale --");
            Console.WriteLine();

            Console.WriteLine("Enter the hurricane category (1-5):");
            int category = int.Parse(Console.ReadLine());

            int mph, kts, kmh;
            switch (category)
            {
                case 1:
                    mph = 74; kts = 64; kmh = 119;
                    Console.WriteLine("Wind speed: {0} mph, {1} kts, {2} km/hr", mph, kts, kmh);
                    break;
                case 2:
                    mph = 96; kts = 83; kmh = 154;
                    Console.WriteLine("Wind speed: {0} mph, {1} kts, {2} km/hr", mph, kts, kmh);
                    break;
                case 3:
                    mph = 111; kts = 96; kmh = 178;
                    Console.WriteLine("Wind speed: {0} mph, {1} kts, {2} km/hr", mph, kts, kmh);
                    break;
                case 4:
                    mph = 131; kts = 114; kmh = 210;
                    Console.WriteLine("Wind speed: {0} mph, {1} kts, {2} km/hr", mph, kts, kmh);
                    break;
                case 5:
                    mph = 156; kts = 135; kmh = 249;
                    Console.WriteLine("Wind speed: >{0} mph, >{1} kts, >{2} km/hr", mph, kts, kmh);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid category input");
                    Console.ResetColor();
                    break;
            }

           
        }
    }
}