using ATMLibrary.Models;
using ATMLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create user objects!
            IUser user_1 = new PinFactory().CreateUser("user1");
            IUser user_2 = new PinFactory().CreateUser("user2");
            IUser user_3 = new PinFactory().CreateUser("user3");
            IUser user_4 = new PinFactory().CreateUser("user4");

            // Create account objects!
            Account account_1 = new AccountFactory().CreateAccount("account1");
            Account account_2 = new AccountFactory().CreateAccount("account2");
            Account account_3 = new AccountFactory().CreateAccount("account3");
            Account account_4 = new AccountFactory().CreateAccount("account4");

            string userName = " ";
            string userAccount = " ";
            double userSaldo = 0;

            Console.Write("Enter your pincode: ");
            string input = Console.ReadLine();

            int userPin = int.Parse(input);

            // Using statements for the view of details depends on user input!
            switch (userPin)
            {
                case 0605:
                    userName = user_1.ToString();
                    userAccount = account_1.ToString();
                    break;
                case 3388:
                    userName = user_2.ToString();
                    userAccount = account_2.ToString();
                    break;
                case 6644:
                    userName = user_3.ToString();
                    userAccount = account_3.ToString();
                    break;
                case 0506:
                    userName = user_4.ToString();
                    userAccount = account_4.ToString();
                    break;
                default:
                    Console.WriteLine("\nIncorrect PIN entered.\n\nDue to security reasons, your account has been blocked.\n\nPlease contact your bank adviser to have the account reopened and assigned a new PIN code.");
                    break;
            }

            if (userPin == 0605 || userPin == 0506 || userPin == 3388 || userPin == 6644)
            {
                Console.WriteLine(userName + userAccount);
                Console.WriteLine("\nATM Menu: \n1) Add to balance. \n2) WithDraw from balance.");
                string nextInput = Console.ReadLine();

                int userChoice = int.Parse(nextInput);

                // Using statements to call method and get data depends on user input!
                switch (userChoice)
                {
                    case 1:
                        Console.Write("Enter the amount to be deposited into your account: ");
                        string addingInput = Console.ReadLine();

                        double userAdd = double.Parse(addingInput);

                        if (userPin == 0605) { userSaldo = Account.AddToAccount(account_1.ABalance, userAdd); }
                        if (userPin == 3388) { userSaldo = Account.AddToAccount(account_2.ABalance, userAdd); }
                        if (userPin == 6644) { userSaldo = Account.AddToAccount(account_3.ABalance, userAdd); }
                        if (userPin == 0506) { userSaldo = Account.AddToAccount(account_4.ABalance, userAdd); }

                        Console.Write("\nYour account balance has been updated to: " + userSaldo + " dkr.");
                        break;
                    case 2:
                        Console.Write("Enter the amount to be withdrawn from your account: ");
                        string withdrawingInput = Console.ReadLine();

                        double userDraw = double.Parse(withdrawingInput);

                        if (userPin == 0605) { userSaldo = Account.WithDrawFromAccount(account_1.ABalance, userDraw); }
                        if (userPin == 3388) { userSaldo = Account.WithDrawFromAccount(account_2.ABalance, userDraw); }
                        if (userPin == 6644) { userSaldo = Account.WithDrawFromAccount(account_3.ABalance, userDraw); }
                        if (userPin == 0506) { userSaldo = Account.WithDrawFromAccount(account_4.ABalance, userDraw); }

                        Console.Write("\nYour account balance has been updated to: " + userSaldo + " dkr.");
                        break;
                    default:
                        Console.WriteLine("\nNot entered correctly.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nHave a nice day.");
            }
            Console.ReadKey();
        }
    }
}
