namespace ACT2g3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox1.Text, out num))
            {
                errorProvider1.SetError(textBox1, "Ingrese solo valores numericos");

            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox1.Text)))
            {
                errorProvider1.Clear();

                MessageBox.Show("Datos Academicos Correctamente");

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Ingrese Nombre");
            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Ingrese Apellido");
            }
            else if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Ingrese Carnet");
            }
            ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
        }
    }
}
