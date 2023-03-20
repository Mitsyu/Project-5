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

        }

        public static void RunHurricane()
        {

        }
    }
}