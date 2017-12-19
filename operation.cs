using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_2
{
    class operation
    {
        public static void PrintTitle(book b)
        {
            b.Show();
        }
        public static void MetodObrabotchik(book b)
        {
            Console.WriteLine("Книга {0} сдана в срок ", b.ToString());
        }
    }
}
