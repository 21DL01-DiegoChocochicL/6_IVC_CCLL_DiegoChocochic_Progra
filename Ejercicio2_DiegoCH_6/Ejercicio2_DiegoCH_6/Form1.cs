namespace Ejercicio2_DiegoCH_6
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
            progressBar1.Value = 0;
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = 1;
                Application.DoEvents();
                Thread.Sleep(100);
            }
            String genero = "";
            if (radioButton1.Checked)
            {
                genero = "Masculino";
            }
            if (radioButton2.Checked) 
            {
                genero = "Femenino";
            }
            Message
        }
    }
}
