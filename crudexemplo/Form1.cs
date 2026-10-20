namespace crudexemplo
{
    public partial class Form1 : Form

    {
        string nome, sobrenomer, curso, RM;
        int ano, idade;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonsalvar_Click(object sender, EventArgs e)
        {
            nome = textboBoxNome.Text;
        }
    }
}
