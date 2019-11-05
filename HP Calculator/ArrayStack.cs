using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_Calculator
{
    class ArrayStack : Stack
    {
        string[] memoryarray = new string[20];
        int arraylength = 0;

        public override void AddItem(string input)
        {
            memoryarray[arraylength] = input;
            arraylength++;
        }

        public override string GetItem(int i)
        {
            return memoryarray[i - 1];
        }

        public override void ChangeItem(double result, int i)
        {
            memoryarray[i - 2] = Convert.ToString(result);
        }

        public override void DeleteItem(int i)
        {
            memoryarray[i - 1] = null;
            arraylength--;
        }

        public override int LengthList()
        {
            return arraylength;
        }
    }
}
