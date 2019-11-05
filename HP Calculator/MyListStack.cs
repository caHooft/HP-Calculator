using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_Calculator
{
    class MyListStack : Stack
    {
        MyList liststuff;
        int mylistlength = 0;

        public override void AddItem(string input)
        {
            if (liststuff == null)
            {
                liststuff = new MyList(input);
            }

            if (liststuff != null)
            {
                Recursie(liststuff, mylistlength).Next(new MyList(input));
                mylistlength++;
            }
        }

        public override string GetItem(int i)
        {
            return Recursie(liststuff, i).GetValue();
        }

        public override void ChangeItem(double result, int i)
        {
            Recursie(liststuff, i - 1).ChangeValue(Convert.ToString(result));
        }

        public override void DeleteItem(int i)
        {
            Recursie(liststuff, i - 1).Next(null);
            mylistlength--;
        }

        public override int LengthList()
        {
            return mylistlength;
        }

        public MyList Recursie(MyList item, int i)
        {
            if (i == 0 || item.Read() == null)
            {
                return item;
            }

            else
            {
                i--;
                return Recursie(item.Read(), i);
            }
        }
    }
}
