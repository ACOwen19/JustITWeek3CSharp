using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace collectionsAndListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //-----------SIMPLE LIST WITH ONE FUNCTION AND AN EXIT CONDITION------------

            //List<string> readingList = new List<string>() { "The Color of Magic", "The Light Fantastic", "Equal Rites" };

            //Console.WriteLine("Add books to your current reading list, enter x to stop and see your current list:");

            //string newBook = Console.ReadLine();
            //do
            //{
            //    readingList.Add(newBook);
            //    Console.WriteLine("Add another book:");
            //    newBook = Console.ReadLine();
            //} while (newBook != "x");



            //int listLength = readingList.Count;

            //for (int i = 0; i < listLength; i += 1)
            //{
            //    Console.WriteLine(readingList[i]);
            //}

            //-----------LIST WITH MULTIPLE FUNCTIONS AND REUSABILITY------------

            List<string> readingList = new List<string>() { "The Color of Magic", "The Light Fantastic", "Equal Rites" };
            string userChoice = "";
            string book = "";
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            Console.WriteLine("This is your reading list, you can add/remove books, sort the list, search for a book or display the full list");
            Console.WriteLine("If you want to quit just choose exit");
            do
            {
                Console.Write("Please choose an option:(add, remove, sort, search, display, exit): ");
                userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "add":
                        Console.WriteLine("Enter a title to add a new book, enter x to stop");
                        book = Console.ReadLine().ToLower();
                        do
                        {
                            readingList.Add(book);
                            Console.WriteLine("Add another book:");
                            book = Console.ReadLine().ToLower();
                        } while (book != "x");
                        break;
                    case "remove":
                        Console.WriteLine("Enter a title to remove a book, enter x to stop");
                        book = Console.ReadLine().ToLower();
                        do
                        {
                            readingList.Remove(book);
                            Console.WriteLine("Remove another book:");
                            book = Console.ReadLine().ToLower();
                        } while (book != "x");
                        break;
                    case "sort":
                        readingList.Sort();
                        Console.WriteLine("List Sorted!");
                        break;
                    case "search":
                        Console.WriteLine("Enter a title see if the book is on the list, enter x to stop");
                        book = Console.ReadLine().ToLower();
                        do
                        {
                            bool inList = readingList.Contains(book);
                            if (inList)
                            {
                                Console.WriteLine(textInfo.ToTitleCase(book) + " is on the list!");
                            }
                            else
                            {
                                Console.WriteLine(textInfo.ToTitleCase(book) + " isn't on the list!");
                            }
                            Console.WriteLine("Search for another book:");
                            book = Console.ReadLine().ToLower();
                        } while (book != "x");
                        break;
                    case "exit":
                        break;
                    case "display":
                        int listLength = readingList.Count;
                        for (int i = 0; i < listLength; i += 1)
                        {
                            Console.WriteLine(textInfo.ToTitleCase(readingList[i]));
                        }
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;
                }
            } while (userChoice != "exit");
            Console.WriteLine("Thanks for using the Reading List!");
        }

    }
}

