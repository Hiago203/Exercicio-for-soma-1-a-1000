using System.Security.Cryptography.X509Certificates;

namespace Exercicio_for_soma_1_a_1000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 0; i < 1000; i++) 
            { 
                soma+=1;
            }
            MessageBox.Show("A soma de 1 a 1000 é: " + soma.ToString());
        }
    }
}