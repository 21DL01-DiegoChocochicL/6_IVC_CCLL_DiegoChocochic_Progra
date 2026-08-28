namespace EjercicioNo3_DiegoChocochic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a = Convert.ToInt32(textBox1);
            b = Convert.ToInt32(textBox2);
            r = a + b;
            label3.Text = r.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text=(Convert.ToInt32(textBox1.Text) + (Convert.ToInt32((textBox2).Text)).ToString();
        }
    }
}
