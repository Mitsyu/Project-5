namespace Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1.");
                Console.WriteLine("2.");
                Console.WriteLine("3.");
                Console.WriteLine("");


                Console.WriteLine("Choose what program to run (1-): ");
                string choice = Console.ReadLine(); 

                switch (choice)
                {

                    case "1":
                        BankProgram();
                        break;
                        
                }
                Console.WriteLine();

            }

            
        }
        private static void BankProgram()
        {
            Random rnd = new Random();
            double bankAccount = rnd.Next(100, 151);

            Console.WriteLine("wel");
            Console.WriteLine("Current balance in your bank account: ${0}", bankAccount );
            Console.WriteLine();

            Console.WriteLine("Enter transaction type (deposit, withdrawal, bill payment, or balance update): ");
            string transactionType = Console.ReadLine();

            Console.WriteLine("Enter transaction amount: ");
            double transactionAmount = double.Parse(Console.ReadLine());



        }
    }
}