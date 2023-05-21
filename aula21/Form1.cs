namespace aula21
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O botao foi apertado");
        }

        private void sendForm(object sender, EventArgs e)
        {
            MessageBox.Show("Botao clicado" + field_name.Text);
        }
    }
}