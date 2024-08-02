using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Milestone1_Exam
{
    public class Book
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string ISBNNo { get; set; }
        public decimal Price { get; set; }
        public string Publisher { get; set; }
        public int NumberOfPages { get; set; }
        public string Language { get; set; }
        public string LoT { get; set; }
        public string Summary { get; set; }

        public Book(string bookID, string bookName, string isbnNo, decimal price, string publisher, int numberOfPages, string summary, string language = "English", string lot = "Technical")
        {
            BookID = bookID;
            BookName = bookName;
            ISBNNo = isbnNo;
            Price = price;
            Publisher = publisher;
            NumberOfPages = numberOfPages;
            Summary = summary;
            Language = language;
            LoT = lot;
        }

        public override string ToString()
        {
            return $"Book ID: {BookID}\n" +
                   $"Book Name: {BookName}\n" +
                   $"ISBN No: {ISBNNo}\n" +
                   $"Price: {Price}\n" +
                   $"Publisher: {Publisher}\n" +
                   $"Number of Pages: {NumberOfPages}\n" +
                   $"Language: {Language}\n" +
                   $"LoT: {LoT}\n" +
                   $"Summary: {Summary}\n";
        }
    }
    class Program
    {
        static List<Book> books = new List<Book>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nLibrary Book Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Delete Book");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine().Trim();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        DisplayBooks();
                        break;
                    case "3":
                        DeleteBook();
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddBook()
        {
            Console.WriteLine("Enter the book details:");

            string bookID;
            do
            {
                Console.Write("Book ID (5 digits): ");
                bookID = Console.ReadLine().Trim();
            } while (!ValidateBookID(bookID));

            string bookName;
            do
            {
                Console.Write("Book Name: ");
                bookName = Console.ReadLine().Trim();
            } while (string.IsNullOrWhiteSpace(bookName));

            Console.Write("ISBN No: ");
            string isbnNo = Console.ReadLine().Trim();

            decimal price;
            while (true)
            {
                Console.Write("Price: ");
                if (decimal.TryParse(Console.ReadLine().Trim(), out price))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid price.");
            }

            Console.Write("Publisher: ");
            string publisher = Console.ReadLine().Trim();

            int numberOfPages;
            while (true)
            {
                Console.Write("Number of Pages: ");
                if (int.TryParse(Console.ReadLine().Trim(), out numberOfPages))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number of pages.");
            }

            Console.Write("Summary: ");
            string summary = Console.ReadLine().Trim();

            string language = "English"; // Default
            string lot = "Technical"; // Default

            // Language input (optional)
            Console.Write("Language (default 'English'): ");
            string inputLanguage = Console.ReadLine().Trim();
            if (!string.IsNullOrWhiteSpace(inputLanguage))
                language = inputLanguage;

            // LoT input (optional)
            Console.Write("LoT (default 'Technical'): ");
            string inputLot = Console.ReadLine().Trim();
            if (!string.IsNullOrWhiteSpace(inputLot))
            {
                while (!ValidateLoT(inputLot))
                {
                    Console.WriteLine("Invalid LoT. Valid values are: .NET, Java, IMS, V&V, BI, RDBMS");
                    Console.Write("LoT (default 'Technical'): ");
                    inputLot = Console.ReadLine().Trim();
                }
                lot = inputLot;
            }

            Book newBook = new Book(bookID, bookName, isbnNo, price, publisher, numberOfPages, summary, language, lot);
            books.Add(newBook);
            Console.WriteLine("Book added successfully.");
        }

        static void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        static void DeleteBook()
        {
            Console.Write("Enter Book ID to delete: ");
            string bookIDToDelete = Console.ReadLine().Trim();

            Book bookToRemove = books.FirstOrDefault(b => b.BookID == bookIDToDelete);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        static bool ValidateBookID(string bookID)
        {
            return bookID.Length == 5 && bookID.All(char.IsDigit);
        }

        static bool ValidateLoT(string lot)
        {
            string[] validLoTs = { ".NET", "Java", "IMS", "V&V", "BI", "RDBMS" };
            return validLoTs.Contains(lot);
        }
    }
}