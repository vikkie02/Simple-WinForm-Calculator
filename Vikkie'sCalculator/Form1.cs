
namespace Vikkie_sCalculator
{
    public partial class Form1 : Form
    {

        Double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()

        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || (operation_pressed))
                Result.Clear();

            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;

        }


        private void operator_click(object sender, EventArgs e)
        {


            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result.Text);
            operation_pressed = true;



        }

        private void button17_Click_1(object sender, EventArgs e)
        {


            switch (operation)


            {

                case "+":
                    Result.Text = (value + Double.Parse(Result.Text)).ToString();

                    break;


                case "-":
                    Result.Text = (value - Double.Parse(Result.Text)).ToString();

                    break;

                case "*":
                    Result.Text = (value * Double.Parse(Result.Text)).ToString();

                    break;


                case "/":
                    Result.Text = (value / Double.Parse(Result.Text)).ToString();

                    break;



                default:
                    break;
            }



            operation_pressed = false;



        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Result.Clear();
            value = 0;

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {




















        }
    }



}






