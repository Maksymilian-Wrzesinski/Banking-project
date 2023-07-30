using System;

class Program
{
    //APP
    static void Main()
    {
        //title
        System.Console.WriteLine("************* MAX BANK *************");
        System.Console.WriteLine("::Login Page::");

        //declare variables name and password
        string userName = null, password = null;

        //write values from user input
        System.Console.Write("Enter username: ");
        userName = System.Console.ReadLine();

        if (userName != "")
        {
            System.Console.Write("Enter password: ");
            password = System.Console.ReadLine();
        }

        //check for username and password
        if (userName=="system" && password == "manager")
        {
            int mainMenuChoice = -1;
            do
            {
                //Main menu choice variable;


                System.Console.WriteLine("\n::::Main menu::::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");
                System.Console.Write("Enter choice number: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                //switch-case to check user input
                switch (mainMenuChoice)
                {
                    case 1:CustomersMenu();
                        break;
                    case 2:AccountsMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 0:
                        break;

                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }

        System.Console.WriteLine("Thank you! Goodbye");
        System.Console.ReadKey();

    }

    static void CustomersMenu()
    {
        //variableto store customer menu choice , display menu
        int customerMenuChoice = -1;
        do
        {
            System.Console.WriteLine("\n::::Customers menu::::");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0. Back to main menu");

            //prompt user to input choice
            System.Console.Write("Enter choice number: ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        int accountMenuChoice = -1;
        do
        {
            System.Console.WriteLine("\n::::Accounts menu::::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Back to main menu");

            //prompt user to input choice
            System.Console.Write("Enter choice number: ");
            accountMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (accountMenuChoice != 0);
    }
}
