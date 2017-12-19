using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_2
{
    class book : item
    {
        private String author;
        private String title;
        private String publisher;
        private int pages;
        private int year;
        private static double price = 9;

        public delegate void ProcessBookDelegate(book book);

        public static event ProcessBookDelegate RetSrok;

        public bool returnSrok = false;
        public bool ReturnSrok
        {
            get
            {
                return returnSrok;
            }
            set
            {
                returnSrok = value;
                if (ReturnSrok == true)
                    RetSrok(this);
            }
        }
        static book()
        {
            price = 10;
        }
        public book() { }
        public book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public book(String author, String title)
        {
            this.author = author;
            this.title = title;
        }

        public void SetBook(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;

        }
        public static void SetPrice(double price)
        {
            book.price = price;
        }
        public override void Show()
        {
            Console.WriteLine("\nBook: \n Author: {0}\n Name: {1}\n Year: {2}\n {3} pages\n Rent price: {4}", author, title, year, pages, book.price);
            base.Show();
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
        public override void Return()
        {
            if (ReturnSrok == true)
                taken = true;
            else
                taken = false;
        }
        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            if (ReturnSrok)
                processBook(this);
        }
        public override string ToString()
        {
            string str = this.title + ", " + this.author + " Инв. номер " + this.invNumber;
            return str;
        }
    }
}
