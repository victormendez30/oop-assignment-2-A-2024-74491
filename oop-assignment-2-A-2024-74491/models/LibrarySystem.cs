using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2_A_2024_74491.models
{
    public class LibrarySystem
    {
        public static void Run()
        {

            while (true)
            { 
                Console.WriteLine("                         ");
                Console.WriteLine("Welcome to our Library System.");
                Console.WriteLine("Please, Choose an option to continue: ");
                Console.WriteLine("1. Display Books");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("                         ");


                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        LibrarySystem.DisplayBooks();
                        break;
                    case "2":
                        LibrarySystem.BorrowBook();
                        break;
                    case "3":
                        LibrarySystem.ReturnBook();
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }



        public static Dictionary<string, bool> books = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase)
        {
            { "Angels and Demons", true },
            { "The Da Vinci Code", true },
            { "Bible", true },
            { "Player Number 1", true }
        };

        public static void DisplayBooks()
        {
            Console.WriteLine("Books Available:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Key} | Status:  {(book.Value ? "Available" : "Borrowed")}");
            }
        }

        public static void BorrowBook()
        {
            Console.Write("Enter the name of the book to borrow: ");
            string bookName = Console.ReadLine();

            if (books.ContainsKey(bookName))
            {
                if (books[bookName])
                {
                    books[bookName] = false;
                    Console.WriteLine($"Great, you borrowed {bookName}. Have a good reading");
                }
                else
                {
                    Console.WriteLine($"Sorry, {bookName} is not available to be borrowed.");
                }
            }
            else
            {
                Console.WriteLine("Book not found. Please check the name of the book, and try again.");
            }
        }

        public static void ReturnBook()
        {
            Console.WriteLine("Enter the name of the book to return: ");
            string bookName = Console.ReadLine();

            if (books.ContainsKey(bookName))
            {
                if (!books[bookName])
                {
                    books[bookName] = true;
                    Console.WriteLine($"You have returned {bookName}.");
                }
                else
                {
                    Console.WriteLine($"{bookName} was not borrowed, this is not our book.");
                }
            }
            else
            {
                Console.WriteLine("Book not found. Please check the 'Title' and try again.");
            }
        }

    }

}

        



       
 
    
