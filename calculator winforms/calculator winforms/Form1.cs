using System.Windows.Forms;
using System.Xml.Linq;

namespace calculator_winforms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String num1og = textBox1.Text;
            String num2og = textBox2.Text;

            Double num1 = Convert.ToDouble(num1og);
            Double num2 = Convert.ToDouble(num2og);
            Double resultbeta = num1 + num2;

            String result = Convert.ToString(resultbeta);

            label1.Text = "Resultado: " + result;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            String num1og = textBox1.Text;
            String num2og = textBox2.Text;

            Double num1 = Convert.ToDouble(num1og);
            Double num2 = Convert.ToDouble(num2og);
            Double resultbeta = num1 - num2;

            String result = Convert.ToString(resultbeta);

            label1.Text = "Resultado: " + result;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String num1og = textBox1.Text;
            String num2og = textBox2.Text;

            Double num1 = Convert.ToDouble(num1og);
            Double num2 = Convert.ToDouble(num2og);
            Double resultbeta = num1 * num2;

            String result = Convert.ToString(resultbeta);

            label1.Text = "Resultado: " + result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String num1og = textBox1.Text;
            String num2og = textBox2.Text;

            Double num1 = Convert.ToDouble(num1og);
            Double num2 = Convert.ToDouble(num2og);
            Double resultbeta = num1 / num2;

            String result = Convert.ToString(resultbeta);

            label1.Text = "Resultado: " + result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por ¬¬ ThePowerdinoDeluxe990", "Informacion");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hola! Porque has pulsado?");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String num1og = textBox1.Text;
            String num2og = textBox2.Text;

            Double num1 = Convert.ToDouble(num1og);
            Double num2 = Convert.ToDouble(num2og);
            Double resultbeta = num1 % num2;

            String result = Convert.ToString(resultbeta);

            label1.Text = "Resultado: " + result;
        }
    }//100 lineas trikitrakatelas
}