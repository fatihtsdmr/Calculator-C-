namespace calculator_ex
{
    public partial class Form1 : Form
    {
        double temp =0;
        double total = 0;
        string num = string.Empty;
        string num2 = string.Empty;
        string operation = string.Empty;

        int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }


        //0
        private void button18_Click(object sender, EventArgs e)
        {


            int button18 = 0;

            num += button18.ToString();
            textBox1.Text = num;


        }
        //1
        private void button1_Click(object sender, EventArgs e)
        {
            int button1 = 1;

            if (flag == 0)
            {

                num += button1.ToString();
                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                num2 += button1.ToString();
                textBox1.Text = num2;

            }
           



        }

        //2
        private void button9_Click(object sender, EventArgs e)
        {
            int button9 = 2;
            if (flag == 0)
            {

                num += button9.ToString();
                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                num2 += button9.ToString();
                textBox1.Text = num2;

            }
        }
        //3
        private void button8_Click(object sender, EventArgs e)
        {
            int button8 = 3;
            if (flag == 0)
            {

                num += button8.ToString();
                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                num2 += button8.ToString();
                textBox1.Text = num2;

            }
        }
        //4
        private void button7_Click(object sender, EventArgs e)
        {
            int button7 = 4;
            if (flag == 0)
            {

                num += button7.ToString();
                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                num2 += button7.ToString();
                textBox1.Text = num2;

            }
        }
        //5
        private void button6_Click(object sender, EventArgs e)
        {
            int button6 = 5;

            if (flag == 0)
            {

                num += button6.ToString();
                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                num2 += button6.ToString();
                textBox1.Text = num2;

            }
        }
        //6
        private void button5_Click(object sender, EventArgs e)
        {
            int button5 = 6;
            if (flag == 0)
            {

                num += button5.ToString();
                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                num2 += button5.ToString();
                textBox1.Text = num2;

            }
        }
        //7
        private void button4_Click(object sender, EventArgs e)
        {
            int button4 = 7;

            if (flag == 0)
            {

                num += button4.ToString();
                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                num2 += button4.ToString();
                textBox1.Text = num2;

            }
        }
        //8
        private void button3_Click(object sender, EventArgs e)
        {
            int button3= 8;
            if (flag == 0)
            {

                num += button3.ToString();
                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                num2 += button3.ToString();
                textBox1.Text = num2;

            }
        }
        //9
        private void button2_Click(object sender, EventArgs e)
        {
            int button2 = 9;
            if (flag == 0)
            {

                num += button2.ToString();
                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                num2 += button2.ToString();
                textBox1.Text = num2;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //+
        private void button14_Click(object sender, EventArgs e)
        {
            operation = "+";
            textBox1.Text = operation;
            flag = 1;
        }

        //-
        private void button15_Click(object sender, EventArgs e)
        {
            operation = "-";
            textBox1.Text = operation;
            flag = 1;
        }

        //x
        private void button16_Click(object sender, EventArgs e)
        {

            operation = "x";
            textBox1.Text = operation;
            flag = 1;

        }
        //÷
        private void button13_Click(object sender, EventArgs e)
        {
            operation = "÷";
            textBox1.Text = operation;
            flag = 1;
        }


        //DEL
        private void button12_Click(object sender, EventArgs e)
        {
            if (num == String.Empty)
            {

            }

            else if (flag == 0)
            {
                num = num.Remove(num.Length - 1, 1);
                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                num2 = num2.Remove(num2.Length - 1, 1);
                textBox1.Text = num2;

            }
        }

        //CE
        private void button11_Click(object sender, EventArgs e)
        {

            total = 0;
           num = string.Empty;
            num2 = string.Empty;
            operation = string.Empty;

            textBox1.Text = num;
        }

        //%
        private void button10_Click(object sender, EventArgs e)
        {
           

            if (flag == 0)
            {

                temp = Double.Parse(num) / 100;
                num = temp.ToString();
                textBox1.Text = num.ToString();


            }

            else if (flag == 1)
            {
                temp = Double.Parse(num2) / 100;
                num2 = temp.ToString();
                textBox1.Text = num2.ToString();


            }
        }


        //=
        private void button17_Click(object sender, EventArgs e)
        {
            if (operation=="+")
            {
                total = Double.Parse(num) + Double.Parse(num2);

                textBox1.Text = total.ToString();


            }
            
            else if (operation == "-")
            {
                total = Double.Parse(num) - Double.Parse(num2);

                textBox1.Text = total.ToString();

            }


            else if(operation == "x")
            {
                total = Double.Parse(num) * Double.Parse(num2);

                textBox1.Text = total.ToString();

            }

            else if (operation == "÷")
            {
                total = Double.Parse(num)/ Double.Parse(num2);

                textBox1.Text = total.ToString();

            }

            flag = 0;

            num=total.ToString();
            num2 = String.Empty;
          
        }

        //,
        private void button19_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {

                num += '.';
                textBox1.Text = num;



            }

            else if (flag == 1)
            {

                num2 += '.';
                textBox1.Text = num2;

             

            }
        }

        // +/-
        private void button20_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                temp = Double.Parse(num) * (-1);
                num = temp.ToString();
               

                textBox1.Text = num;

            }

            else if (flag == 1)
            {
                temp = Double.Parse(num2) * (-1);
                num2 = temp.ToString();

                textBox1.Text = num2;

            }
        }
    }
}