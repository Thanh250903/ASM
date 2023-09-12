using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1651
{
    internal class BorrowBook
    {
        private string idBook;
        private string nameBorrow;
        private string phone;
        private string dateBorrow;
        private string dateReturn;

        public BorrowBook(string idBook, string nameBorrow, string phone, string dateBorrow, string dateReturn)
        {
    
            this.idBook = idBook;
            this.nameBorrow = nameBorrow;
            this.phone = phone; 
            this.dateBorrow = dateBorrow;
            this.dateReturn = dateReturn;
        }
        public BorrowBook()
        {

        }
      
        public override string ToString()
        {
            return
                 "', ID Book: '" + this.idBook
                + "', Borrower's name : '" + this.nameBorrow
                + "', Phone: '" + this.phone
                + "', Date Borrow: '" + this.dateBorrow
                 + "', Date Return: '" + this.dateReturn;
        }
    }
}