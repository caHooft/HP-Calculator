using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_Calculator
{
    class ListStack : Stack
    {
        List<string> memorylist = new List<string>();


        public override void AddItem(string input)
        {
            memorylist.Add(input);
        }

        public override string GetItem(int i)
        {
            return memorylist[i - 1];
        }

        public override void ChangeItem(double result, int i)
        {
            memorylist[i - 2] = Convert.ToString(result);
        }

        public override void DeleteItem(int i)
        {
            memorylist.RemoveAt(i - 1);
        }

        public override int LengthList()
        {
            return memorylist.Count;
        }
    }
}
