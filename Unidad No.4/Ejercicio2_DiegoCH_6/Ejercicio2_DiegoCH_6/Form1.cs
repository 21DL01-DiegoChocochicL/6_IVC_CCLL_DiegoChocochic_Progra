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
                progressBar1.Value = i;
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
            MessageBox.Show("Datos del Estudiante\n\n" + "Nombre:" + textBox1.Text + "\nEdad:" + numericUpDown1.Value + "\nNimvel Academico:" + comboBox1.Text +
                "\nFecha de Nacimiento:" + dateTimePicker1.Text + "\nGenero:" + genero + "\nEsto es Informacion del Estudiante inscrito");

  

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Title = "Seleccione una fotografia";
            abrir.Filter = "Archivos tipo|* .jpg;*.png;*";

            if (abrir.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(abrir.FileName);
            }
        }
    }
}
