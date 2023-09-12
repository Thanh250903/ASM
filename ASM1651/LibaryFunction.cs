using ASM1651;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1651
{
    public class LibaryFunction
    {
        private static List<Book> books = new List<Book>();
        private static List<BorrowBook> borrowBooks = new List<BorrowBook>();
        private static List<Librarian> librarians = new List<Librarian>();
       
        //public void displayListBook()
        //{
        //    foreach (Book book in books)
        //    {
        //        Console.WriteLine(book.ToString());
        //    }
        //}
        //public void addBook(Book book)
        //{
        //    books.Add(book);    
        //}
        //public void editBook(string id)
        //{
        //    foreach (Book book in books)
        //    {
        //        if (book.getIdBook().Equals(id))
        //        {
        //            Console.Write("Name of Book: ");
        //            string nameBook = Console.ReadLine();
        //            Console.Write("Author of Book: ");
        //            string authorBook = Console.ReadLine();
        //            Console.Write("Category of Book: ");
        //            string category = Console.ReadLine();
        //            Console.Write("Price Book: ");
        //            double price = double.Parse(Console.ReadLine());
        //            Console.Write("Quantity: ");
        //            int quatity = int.Parse(Console.ReadLine());
        //            Console.WriteLine("Enter the language: ");
        //            string language = Console.ReadLine();
        //            Console.WriteLine("Enter the semester: ");
        //            string semester = Console.ReadLine();   
        //            book.setNameBook(nameBook);
        //            book.setAuthorBook(authorBook);
        //            book.setCategoryBook(category);
        //            book.setPriceBook(price);
        //            book.setQuantity(quatity);
        //        }
        //    }
        //}
        //public void removeBook(string id)
        //{
        //    foreach (Book book in books)
        //    {
        //        if (book.getIdBook().Equals(id))
        //        {
        //            books.Remove(book);
        //            break;
        //        }
        //    }
        //}

        //public void findBook(string info)
        //{
        //    foreach (Book book in books)
        //    {
        //        if (book.getIdBook().Equals(info) || book.getNameBook().Equals(info) || book.getpublicationYear().Equals(info) || book.getCategoryBook().Equals(info))
        //        {
        //            Console.Write(book.ToString());
        //        }
        //    }
        //}

        public void displayInforBorrowBook()
        {
            foreach (BorrowBook borrow in borrowBooks)
            {
                Console.WriteLine(borrow.ToString());
            }
        }
        internal void addBorrowBook(BorrowBook borrow)
        {
            borrowBooks.Add(borrow);
        }
        public void displayInformationLibrarian()
        {
            foreach (Librarian librarian in librarians)
            {
                Console.WriteLine(librarian.ToString());
            }
        }
        internal void addLibrarian(Librarian librarian)
        {
            librarians.Add(librarian);
        }

        //public void findLibrarian(string infor)
        //{
        //    foreach (Librarian librarian in librarians)
        //    {
        //        if (librarian.getname().Equals(infor) || librarian.getage().Equals(infor) || librarian.getidCard().Equals(infor) || librarian.getPhoneNumber().Equals(infor) || librarian.getgetKPI().Equals(infor) || librarian.getsalary().Equals(infor))
        //            Console.WriteLine(librarian.ToString());
        //    }
        //}
        public string checkIdBook()
        {
            while (true)
            {
                Console.Write("ID Book: ");
                string idBook = Console.ReadLine();
                foreach (Book book in books)
                {
                    if (book.getIdBook().Equals(idBook) && book.getQuatity() != 0)
                    {
                        book.setQuantity(book.getQuatity() - 1);
                        return idBook;
                    }
                    else
                    {
                        Console.WriteLine("ID Book not found in library.");
                        Console.WriteLine("Please enter id book again!!!!");
                    }
                }
            }
        }
        //public string checkidBorrow()
        //{
        //    while (true)
        //    {
        //        Console.Write("Enter ID: ");
        //        string idBorrow = Console.ReadLine();
        //        foreach(BorrowBook borrowBook in borrowBooks)
        //        {
        //            if(borrowBook.getID().Equals(idBorrow) == borrowBook.getID().Equals(idBorrow))
        //            {
        //                borrowBook.setId(borrowBook.getID());
        //                return idBorrow;
        //            }
        //            else
        //            {
        //                Console.WriteLine("This ID has been repeat or incorrect, please try again");
        //            }
        //        }
        //    }
        //}
    }
}
