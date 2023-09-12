using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ASM1651
{
    public class Book
    {
        private List<Book> books = new List<Book>();
         private string idBook;
         private string nameBook;
         private string categoryBook;
         private string authorBook;
         private string publicationYear;
         private double priceBook;
         private int quantity;

        public string IdBook { get; set; }
        public void setIdBook(string idBook) 
        {
            this.idBook = idBook;
        }
        public string getIdBook()
        {
            return idBook;
        }
        public void setNameBook(string nameBook)
        {
            this.nameBook = nameBook;
        }
        public string getNameBook()
        {
            return nameBook;
        }
        public void setAuthorBook(string authorBook)
        {
            this.authorBook = authorBook;
        }
        public string getAuthorBook()
        {
            return authorBook;
        }
        public void setCategoryBook(string categoryBook)
        {
            this.categoryBook = categoryBook;
        }
        public string getCategoryBook()
        {
            return categoryBook;
        }
        public void setPublicationYear(string publicationYear)
        {
            this.publicationYear = publicationYear;
        }
        public string getpublicationYear()
        {
            return publicationYear;
        }
        public void setPriceBook(double priceBook)
        {
            this.priceBook = priceBook;
        }
        public double getPriceBook()
        {
            return priceBook;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getQuatity()
        {
            return quantity;
        }
        public Book(string idbook, string namebook, string authorbook, string categorybook, string publicationyear, double pricebook, int quantity)
        {
            this.idBook = idbook;
            this.nameBook = namebook;
            this.authorBook = authorbook;
            this.categoryBook = categorybook;
            this.publicationYear = publicationyear;
            this.priceBook = pricebook;
            this.quantity = quantity;
        }
        public Book() { }
       
        public override string ToString()
        {
            return "ID Book: '" + this.idBook
                + "', Name Book: '" + this.nameBook
                + "', Author Book: '" + this.authorBook
                //+ "', Category Book: '" + this.categoryBook
                + "', Price Book: '" + this.priceBook
                + "', Quantity Book: '" + this.quantity;
        }
        public void displayListBook()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
        public void addBook(Book book)
        {
            books.Add(book);
        }
        public void editBook(string id)
        {
            foreach (Book book in books)
            {
                if (book.getIdBook().Equals(id))
                {
                    Console.Write("Name of Book: ");
                    string nameBook = Console.ReadLine();
                    Console.Write("Author of Book: ");
                    string authorBook = Console.ReadLine();
                    Console.Write("Category of Book: ");
                    string category = Console.ReadLine();
                    Console.Write("Price Book: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Quantity: ");
                    int quatity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the language: ");
                    string language = Console.ReadLine();
                    Console.WriteLine("Enter the semester: ");
                    string semester = Console.ReadLine();
                    book.setNameBook(nameBook);
                    book.setAuthorBook(authorBook);
                    book.setCategoryBook(category);
                    book.setPriceBook(price);
                    book.setQuantity(quatity);
                }
            }
        }
        public void removeBook(string id)
        {
            foreach (Book book in books)
            {
                if (book.getIdBook().Equals(id))
                {
                    books.Remove(book);
                    break;
                }
            }
        }

        public void findBook(string info)
        {
            foreach (Book book in books)
            {
                if (book.getIdBook().Equals(info) || book.getNameBook().Equals(info) || book.getpublicationYear().Equals(info) || book.getCategoryBook().Equals(info))
                {
                    Console.Write(book.ToString());
                }
            }
        }
    }
}