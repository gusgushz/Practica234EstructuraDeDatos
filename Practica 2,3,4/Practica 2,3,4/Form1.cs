namespace Practica_2_3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxFact.Text);
                Calculadora calculadorsita = new Calculadora();
                ResultFact.Text = calculadorsita.CalcularFact(n).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor de insertar valores numéricos en el cuadro", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFact.Text = "";
                ResultFact.Text = "";
            }
        }

        private void buttonFibo_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxFibo.Text);
                Calculadora calculadorsita = new Calculadora();
                ResultFibo.Text = calculadorsita.CalcularFibo(n).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor de insertar valores numéricos en todos los cuadros", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFibo.Text = "";
                ResultFibo.Text = "";
            }
        }

        private void buttonMCD_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBoxMCD1.Text);
                int x = int.Parse(textBoxMCD2.Text);
                Calculadora calculadorsita = new Calculadora();
                ResultMCD.Text = calculadorsita.CalcularMCD(n, x).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor de insertar valores numéricos en todos los cuadros", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMCD1.Text = "";
                textBoxMCD2.Text = "";
                ResultMCD.Text = "";
            }
        }
    }

    public class Calculadora
    {
        public int CalcularFact(int n) // fact4 = 4 * fact3(3 * fact2(2 * fact1(1))) EJEMPLO.
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else if (n > 1)
            {
                return n = n * CalcularFact(n - 1);
            }
            else
            {
                return 0;
            }
        }
        public int CalcularFibo(int n)
        { // fibo5 = fibo4 (fibo3(fibo2(1+0)+fibo1(1)) + fibo2(1+0)) + fibo3 (fibo2(1+0) + fibo1(1)) EJEMPLO
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n > 1)
            {
                return n = CalcularFibo(n - 1) + CalcularFibo(n - 2);
            }
            else
            {
                return 0;
            }
        }
        public int CalcularMCD(int n, int x) //Dos numeros
        { // 10, 8. 10/8=2,sobra 2.Luego 2,8. 8/2=4 sobra 0. Luego 0,2, Al ser n=0, retorna x, que es 2.
            if (n == 0)
            {
                return x;
            }
            else if (n > 1)
            {
                return CalcularMCD(x % n, n);
            }
            else
            {
                return 0;
            }
        }
    }
}