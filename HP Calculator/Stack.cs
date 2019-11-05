using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_Calculator
{
    abstract class Stack
    {
        public abstract void AddItem(string input);

        public abstract string GetItem(int i);

        public abstract void ChangeItem(double result, int i);

        public abstract void DeleteItem(int i);

        public abstract int LengthList();
    }
}
