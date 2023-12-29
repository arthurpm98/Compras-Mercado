namespace ComprasMercado
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        BancoDeDados banco = new BancoDeDados();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (VerificaPreenchimentoDosCampos() == true)
            {
                banco.Servidor = txtServidor.Text.ToString();
                banco.UsuarioBanco = txtUsuario.Text.ToString();
                banco.SenhaUsuario = txtSenha.Text.ToString();
                //Abre conexão com o banco de dados.
                banco.ConectaDB(true);
                var formMenuPrincipal = new FormMenuPrincipal(txtServidor.Text.ToString(), txtUsuario.Text.ToString(), txtSenha.Text.ToString());
                this.Hide();
                formMenuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Preencha os campos com os dados do usuário do banco de dados.");
            }

        }

        private bool VerificaPreenchimentoDosCampos()
        {
            if (txtUsuario.Text != "" && txtServidor.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
