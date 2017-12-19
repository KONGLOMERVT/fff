using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            book b1 = new book("Достоевский Ф.М.", "Братья Карамазовы", "Вильямс", 2035, 2000, 1, true);
            b1.SetBook("Достоевский Ф.М.", "Братья Карамазовы", "Вильямс", 2035, 2000);
            book.SetPrice(12);
            b1.Show();

            Console.WriteLine("\n Finally price for rent: {0} p.", b1.PriceBook(3));
            book b2 = new book("Лондон Джек", "Мартин Иден", "Литература", 560, 2006, 10, true);
            book.SetPrice(30);
            b2.TakeItem();
            b2.Show();
            Console.WriteLine("\n Finally price for rent: {0} p.", b2.PriceBook(14));
            book b3 = new book("Уильям Теккерей", "Ярмарка тщеславия", "Мектеп", 1324, 2001, 5, true);
            book.SetPrice(100);
            b3.Show();
            Console.WriteLine("\n Finally price for rent: {0} p.", b3.PriceBook(5));

            magazine m1 = new magazine("FORBES", 5, "Top programmers", 2014, 12, true);
            book.SetPrice(75);
            m1.TakeItem();
            m1.Show();
            m1.Ifsubs = true;
            m1.subs();
            Console.WriteLine("\nТестирование полиморфизма");
            item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it.Show();
            it = m1;
            it.TakeItem();
            it.Return();
            it.Show();
            item[] itmas = new item[4];
            itmas[0] = b1;
            itmas[1] = b2;
            itmas[2] = b3;
            itmas[3] = m1;
            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach (item x in itmas)
            {
                x.Show();
            }
            book b4 = new book("Маркез Габриель", "Сто лет одиночества", "Золотой век", 607, 2012, 14, true);
            book b5 = new book("Джейн Остин", "Гордость и предубеждение", "Весна", 487, 1999, 88, true);
            book.RetSrok += new book.ProcessBookDelegate(operation.MetodObrabotchik);
            b4.ReturnSrok = true;
            b5.ReturnSrok = true;
            System.Console.WriteLine("\nКниги возвращаем в срок: ");
            b4.ProcessPaperbackBooks(operation.PrintTitle);
            b5.ProcessPaperbackBooks(operation.PrintTitle);
            Console.ReadKey();
        }
    }
}
