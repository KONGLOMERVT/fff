using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_2
{
    class magazine : item, ipubs
    {
        private String volume;
        private String title;
        private int number;
        private int year;

        public bool Ifsubs { get; set; }
        public void subs()
        {
            Console.WriteLine("Подписка на журнал \"{0}\": {1}", title, Ifsubs);
        }

        public magazine(String volume, int number, String title, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public magazine()
        {

        }

        public override void Show()
        {
            Console.WriteLine("\nЖурнал:\nТом: {0}\nНомер: {1}\nНазвание: {2}\nГод выпуска: {3}", volume, number, title, year);
            base.Show();
        }
        public override void Return()
        {
            taken = true;
        }
    }
}
