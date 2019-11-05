using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_Calculator
{
    class MyList
    {
        string value;
        MyList mylist;

        public MyList(string input)
        {
            value = input;
        }

        public void Next(MyList next)
        {
            mylist = next;
        }

        public MyList Read()
        {
            return mylist;
        }

        public string GetValue()
        {
            return value;
        }

        public void ChangeValue(string s)
        {
            value = s;
        }
    }
}
