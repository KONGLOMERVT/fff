using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_2
{
    abstract class item : IComparable
    {
        protected long invNumber;
        protected bool taken;

        int IComparable.comp(object obj)
        {
            item it = (item)obj;
            if (this.invNumber == it.invNumber) return 0;
            else if (this.invNumber > it.invNumber) return 1;
            else return -1;
        }

        public item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public item()
        {
            this.taken = true;
        }
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        public long GetInvNumber()
        {
            return invNumber;
        }

        private void Take()
        {
            taken = false;
        }
        abstract public void Return();
        public virtual void Show()
        {
            Console.WriteLine("Состояние единицы хранения:\nИнвентарный номер: {0}\nНаличие: {1}", invNumber, taken);
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }
    }
}
