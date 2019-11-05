using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HP_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Design();
        }

        Label display = new Label();
        ListBox inputlb = new ListBox();
        RadioButton listbutton = new RadioButton();
        RadioButton arraybutton = new RadioButton();
        RadioButton mylistbutton = new RadioButton();

        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();
        Button button6 = new Button();
        Button button7 = new Button();
        Button button8 = new Button();
        Button button9 = new Button();
        Button button0 = new Button();
        Button buttonadd = new Button();
        Button buttonclear = new Button();
        Button buttonplus = new Button();
        Button buttonminus = new Button();
        Button buttontimes = new Button();
        Button buttondivide = new Button();
        Button buttonback = new Button();
        Button buttonneg = new Button();
        Button buttondot = new Button();
       
        Stack stack = new ListStack();

        public string whatstack = "ListStack";
        public int dotcount = 0;
        public string rescol;

        public void Design()
        {
            this.Size = new Size(666, 525);
            this.Location = new Point(-10, 10);

            this.KeyPreview = true;
            this.KeyPress += TheKey_KeyPress;

            this.Controls.Add(inputlb);
            inputlb.Size = new Size(216, 439);
            inputlb.Font = new Font("Times New Roman", 24);

            this.Controls.Add(display);
            display.Size = new Size(432,64);
            display.Location = new Point(218, 0);
            display.Text = "0";
            display.BackColor = ColorTranslator.FromHtml("#323235");
            display.Font = new Font("Times New Roman", 36);
            display.ForeColor = ColorTranslator.FromHtml("#2abf22");

            this.Controls.Add(listbutton);
            listbutton.Size = new Size(144, 25);
            listbutton.Location = new Point(218, 440);
            listbutton.Text = "ListStack";
            listbutton.Font = new Font("Times New Roman", 13);
            listbutton.Click += Radio_Click;
            listbutton.Checked = true;

            this.Controls.Add(arraybutton);
            arraybutton.Size = new Size(144, 25);
            arraybutton.Location = new Point(362, 440);
            arraybutton.Text = "ArrayStack";
            arraybutton.Font = new Font("Times New Roman", 13);
            arraybutton.Click += Radio_Click;


            this.Controls.Add(mylistbutton);
            mylistbutton.Size = new Size(144, 25);
            mylistbutton.Location = new Point(506, 440);
            mylistbutton.Text = "MyListStack";
            mylistbutton.Font = new Font("Times New Roman", 13);
            mylistbutton.Click += Radio_Click;

            {
                this.Controls.Add(button1);
                button1.Size = new Size(108, 75);
                button1.Location = new Point(326, 64);
                button1.Text = "1";
                button1.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                button1.Font = new Font("Times New Roman", 24);
                button1.Click += TheButton_Click;

                this.Controls.Add(button2);
                button2.Size = new Size(108, 75);
                button2.Location = new Point(434, 64);
                button2.Text = "2";
                button2.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                button2.Font = new Font("Times New Roman", 24);
                button2.Click += TheButton_Click;

                this.Controls.Add(button3);
                button3.Size = new Size(108, 75);
                button3.Location = new Point(542, 64);
                button3.Text = "3";
                button3.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                button3.Font = new Font("Times New Roman", 24);
                button3.Click += TheButton_Click;

                this.Controls.Add(button4);
                button4.Size = new Size(108, 75);
                button4.Location = new Point(326, 139);
                button4.Text = "4";
                button4.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                button4.Font = new Font("Times New Roman", 24);
                button4.Click += TheButton_Click;

                this.Controls.Add(button5);
                button5.Size = new Size(108, 75);
                button5.Location = new Point(434,139);
                button5.Text = "5";
                button5.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                button5.Font = new Font("Times New Roman", 24);
                button5.Click += TheButton_Click;

                this.Controls.Add(button6);
                button6.Size = new Size(108, 75);
                button6.Location = new Point(542, 139);
                button6.Text = "6";
                button6.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                button6.Font = new Font("Times New Roman", 24);
                button6.Click += TheButton_Click;

                this.Controls.Add(button7);
                button7.Size = new Size(108, 75);
                button7.Location = new Point(326, 214);
                button7.Text = "7";
                button7.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                button7.Font = new Font("Times New Roman", 24);
                button7.Click += TheButton_Click;

                this.Controls.Add(button8);
                button8.Size = new Size(108, 75);
                button8.Location = new Point(434, 214);
                button8.Text = "8";
                button8.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                button8.Font = new Font("Times New Roman", 24);
                button8.Click += TheButton_Click;

                this.Controls.Add(button9);
                button9.Size = new Size(108, 75);
                button9.Location = new Point(542, 214);
                button9.Text = "9";
                button9.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                button9.Font = new Font("Times New Roman", 24);
                button9.Click += TheButton_Click;

                this.Controls.Add(button0);
                button0.Size = new Size(108, 75);
                button0.Location = new Point(434, 289);
                button0.Text = "0";
                button0.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                button0.Font = new Font("Times New Roman", 24);
                button0.Click += TheButton_Click;

                this.Controls.Add(buttonneg);
                buttonneg.Size = new Size(108, 75);
                buttonneg.Location = new Point(326, 289);
                buttonneg.Text = "+/-";
                buttonneg.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                buttonneg.Font = new Font("Times New Roman", 24);
                buttonneg.Click += Buttonneg_Click;

                this.Controls.Add(buttondot);
                buttondot.Size = new Size(108, 75);
                buttondot.Location = new Point(542, 289);
                buttondot.Text = ".";
                buttondot.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                buttondot.Font = new Font("Times New Roman", 24);
                buttondot.Click += TheButton_Click;

                this.Controls.Add(buttonplus);
                buttonplus.Size = new Size(108, 75);
                buttonplus.Location = new Point(218, 64);
                buttonplus.Text = "+";
                buttonplus.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                buttonplus.Font = new Font("Times New Roman", 24);
                buttonplus.Click += TheButton_Click;


                this.Controls.Add(buttonminus);
                buttonminus.Size = new Size(108, 75);
                buttonminus.Location = new Point(218, 139);
                buttonminus.Text = "-";
                buttonminus.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                buttonminus.Font = new Font("Times New Roman", 24);
                buttonminus.Click += TheButton_Click;


                this.Controls.Add(buttontimes);
                buttontimes.Size = new Size(108 ,75);
                buttontimes.Location = new Point(218, 214);
                buttontimes.Text = "*";
                buttontimes.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                buttontimes.Font = new Font("Times New Roman", 24);
                buttontimes.Click += TheButton_Click;


                this.Controls.Add(buttondivide);
                buttondivide.Size = new Size(108, 75);
                buttondivide.Location = new Point(218, 289);
                buttondivide.Text = "/";
                buttondivide.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                buttondivide.Font = new Font("Times New Roman", 24);
                buttondivide.Click += TheButton_Click;

                this.Controls.Add(buttonadd);
                buttonadd.Size = new Size(216, 75);
                buttonadd.Location = new Point(434, 364);
                buttonadd.Text = "Add";
                buttonadd.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                buttonadd.Font = new Font("Times New Roman", 24);
                buttonadd.Click += Buttonadd_Click;

                this.Controls.Add(buttonclear);
                buttonclear.Size = new Size(216, 75);
                buttonclear.Location = new Point(218, 364);
                buttonclear.Text = "Clear";
                buttonclear.BackColor = ColorTranslator.FromHtml("#b8b8b8");
                buttonclear.Font = new Font("Times New Roman", 24);
                buttonclear.Click += Buttonclear_Click;
            }
        }

        public void TheButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string number = button.Text;

            CheckKey(number);
        }

        public void TheKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            string key = Convert.ToString(e.KeyChar);

            CheckKey(key);
        }

        public void Buttonadd_Click(object sender, EventArgs e)
        {
            stack.AddItem(display.Text);

            dotcount = 0;
            UpdateLB();
        }

        public void Buttonclear_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
            {
                display.Text = "0";
            }

            dotcount = 0;
        }

        public void Buttonneg_Click(object sender, EventArgs e)
        {
            int original = Convert.ToInt32(display.Text);
            int newtxt;

            newtxt = original * -1;

            display.Text = Convert.ToString(newtxt);
        }

        public void Radio_Click(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            string stacktype = button.Text;

            SwitchStack(stacktype);
        }

        public void CheckKey(string s)
        {
            string key = s;
            char keyc = Convert.ToChar(s);

            if (char.IsDigit(keyc))
            {
                AddNumber(key);
            }

            else if (key.Contains('.'))
            {
                if (display.Text != "0")
                {
                    if (dotcount == 0)
                    {
                        AddNumber(key);
                        dotcount++;
                    }
                }
            }

            else if (key.Contains('+') || key.Contains('-') || key.Contains('*') || key.Contains('/'))
            {
                if (stack.LengthList() > 1)
                {
                    Calculate(key);
                }
            }
        }

        public void AddNumber(string s)
        {
            if (display.Text != "0")
            {
                display.Text += s;
            }

            if (display.Text == "0")
            {
                if (s != "0")
                {
                    display.Text = s;
                }
            }
        }

        public void Calculate(string s)
        {
            string operation = s;
            double result = 0;
            double number1 = (Convert.ToDouble(stack.GetItem(stack.LengthList() - 1)));
            double number2 = (Convert.ToDouble(stack.GetItem(stack.LengthList())));

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    break;
            }

            ChangeResCol(result);
            stack.ChangeItem(result, (stack.LengthList()));
            stack.DeleteItem(stack.LengthList());

            UpdateLB();
        }

        public void SwitchStack(string s)
        {
            whatstack = s;

            switch (whatstack)
            {
                case "ListStack":
                    stack = new ListStack();
                    break;
                case "ArrayStack":
                    stack = new ArrayStack();
                    break;
                case "MyListStack":
                    stack = new MyListStack();
                    break;
            }

            UpdateLB();
        }

        public void UpdateLB()
        {
            inputlb.Items.Clear();

            for (int i = stack.LengthList(); i > 0; i--)
            {
                inputlb.Items.Add(stack.GetItem(i));
            }

            display.Text = "0";
        }

        public void ChangeResCol(double result)
        {
            string res = Convert.ToString(result);
        }
    }
}
