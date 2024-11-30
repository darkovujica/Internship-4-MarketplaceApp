using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceApp.Domain;
using MarketplaceApp.Domain.Repositories;

namespace MarketplaceApp.Presentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            var exitMenu = false;
            do
            {
                Console.Clear();
                Console.Write("Do you want to sign up or log in?\n1 - Sign up\n2 - Log in\n3 - ExitMenu\n");
                var choosenOption = ChooseOption(new List<int>() { 1, 2, 3});

                Console.Clear();
                switch (choosenOption)
                {
                    case 1:
                        UserSignUp();
                        break;
                    case 2:
                        UserLogIn();
                        break;
                    case 3:
                        exitMenu = true;
                        break;
                    default:
                        break;
                }

            } while (!exitMenu);
            Console.Clear();
        }
        static void UserSignUp()
        {
            var name = NewString("Enter your first name: ");
            var email = NewEmail("Enter your email: ");
            while (UserRepository.EmailExists(email))
            {
                Console.Write("There is already user with that email. ");
                email = NewEmail("Enter your email: ");
            }

            Console.Write("Are you buyer or seller?\n1 - Buyer\n2 - Seller\n");
            if (ChooseOption(new List<int>() { 1, 2 }) == 1)
            {
                var balance = NewPositiveDouble("Enter your balance: ");
                UserRepository.AddNewBuyer(name, email, balance);
                BuyerMenu(email);
            }
            else
            {
                UserRepository.AddNewSeller(name, email);
                SellerMenu(email);
            }  
        }
        static void UserLogIn()
        {
            var email = NewEmail("Enter your email: ");
            while (!UserRepository.EmailExists(email))
            {
                Console.Write("There is no user with that email. ");
                email = NewEmail("Enter your email: ");
            }
            var isBuyer = UserRepository.IsBuyer(email);
            if (isBuyer)
                BuyerMenu(email);
            else
                SellerMenu(email);
        }
        static void BuyerMenu(string email)
        {
            var buyer = new BuyerRepository(email);
            var exitMenu = false;
            do
            {
                Console.Clear();
                Console.Write("1 - View all available items\n2 - Buy item\n3 - Return item\n4 - Add item to favorites\n5 - View your bought items\n6 - View your favorites\n7 - Log out\n");
                var choosenOption = ChooseOption(new List<int>() { 1, 2, 3, 4, 5, 6, 7 });

                Console.Clear();
                switch (choosenOption)
                {
                    case 1:
                        buyer.ViewAllItems();
                        break;
                    case 2:
                        buyer.BuyItem(ChooseItemId());
                        break;
                    case 3:
                        buyer.ReturnItem(ChooseItemId());
                        break;
                    case 4:
                        buyer.AddTofavorites(ChooseItemId());
                        break;
                    case 5:
                        buyer.ViewAllBoughtItems();
                        break;
                    case 6:
                        buyer.ViewAllFavoriteItems();
                        break;
                    case 7:
                        exitMenu = true;
                        break;
                    default:
                        break;
                }

            } while (!exitMenu);
            Console.Clear();
        }
        static void SellerMenu(string email)
        {
            var seller = new SellerRepository(email);
            var exitMenu = false;
            do
            {
                Console.Clear();
                Console.Write("1 - Add item\n2 - View your items\n3 - Earnings\n4 - View sold items by category\n5 - Earnings in a certain period\n6 - Log out\n");
                var choosenOption = ChooseOption(new List<int>() { 1, 2, 3, 4, 5, 6});

                Console.Clear();
                switch (choosenOption)
                {
                    case 1:
                        var name = NewString("Enter new item name: ");
                        var description = NewString("Enter item description: ");
                        var price = NewPositiveDouble("Enter item price: ");
                        seller.AddItem(name, description, price);
                        break;
                    case 2:
                        seller.ViewAllItems();
                        break;
                    case 3:
                        Console.WriteLine($"Earnings: {seller.SeeEarnings()}");
                        break;
                    case 4:
                        Console.Write("1 - Electronics\n2 - Clothes\n3 - Books\n4 - Jewelry\n5 - Food\n6 - Unknown");
                        var option = ChooseOption(new List<int>() {1,2,3,4,5,6 });
                        seller.ViewItemsByCategory(option);
                        break;
                    case 5:

                        break;
                    case 6:
                        exitMenu = true;
                        break;
                    default:
                        break;
                }

            } while (!exitMenu);
            Console.Clear();
        }



        
        static int ChooseItemId()
        {
            var id = -1;
            do
            {
                id = NewNumber("Enter item ID: ");
            } while (!ItemRepository.ItemExists(id));
            return id;
        }
        static string NewEmail(string message)
        {
            var validEmail = false;
            var email = "";
            do
            {
                Console.Write(message);
                email = Console.ReadLine();
                var sepByAt = email.Split('@');
                var sepBySpace = email.Split();

                if (sepBySpace.Length == 1 && sepByAt.Length == 2 && sepByAt[1].Split('.').Length == 2)
                    validEmail = true;
                else
                    Console.Write("This is not valid email. ");
            } while (validEmail);
            return email;
        }
        static string NewString(string message)
        {
            var notString = false;
            var myString = "";
            do
            {
                Console.Write(message);
                myString = Console.ReadLine();

                foreach (var item in myString)
                {
                    if (item.ToString().ToUpper() == item.ToString().ToLower())
                        notString = true;
                }
                if (notString)
                    Console.WriteLine("Use letters only. Try again. ");
            }while(notString);

            return myString;
        }
        static int NewNumber(string message, int upperLimit = int.MaxValue)
        {
            var myOption = 0;
            do
            {
                Console.Write(message);
                if (!int.TryParse(Console.ReadLine(), out myOption))
                    Console.Write("You didn't enter number/integer. ");

                else if (myOption <= 0)
                    Console.Write($"Please enter positive number. ");

                else if (upperLimit != int.MaxValue && myOption > upperLimit)
                    Console.Write($"Please enter number lower than {upperLimit}. ");

            } while (myOption <= 0 || myOption > upperLimit);

            return myOption;
        }
        static double NewPositiveDouble(string message)
        {
            Console.Write(message);
            var myOption = -1.0;

            while (!double.TryParse(Console.ReadLine(), out myOption) && myOption<0)
                Console.Write("Enter positive number. " + message);

            return myOption;
        }
        static int ChooseOption(List<int> options)
        {
            do
            {
                var myOption = NewNumber("Choose number: ");
                foreach (var item in options)
                {
                    if (item == myOption)
                        return myOption;
                }
                Console.Write("Choosen number is not an option. ");
            } while (true);
        }
    }
}
