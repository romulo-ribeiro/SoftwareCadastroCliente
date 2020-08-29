using Negócios;
using System;
using System.Windows.Forms;

namespace SoftwareCadastroCliente
{
    
    public partial class TelaLogin : Form
    {
        public bool cadastrado = false;
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            UsuarioDados banco = new UsuarioDados();
            UsuarioModel login = new UsuarioModel()
            {
                Usuario = txt_Usuario.Text,
                Senha = txt_Senha.Text
            };

            if (banco.Read(login).Count > 0)
            {
                TelaIntermediaria tela = new TelaIntermediaria();
                this.Hide();
                tela.ShowDialog();

            }
            else
            {
                TelaAviso aviso = new TelaAviso();
                aviso.lbl_Aviso.Text = "Usuário não existe!";
                aviso.Show();
            }
        }

        private void lnk_Cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastroUsuario cadastro = new TelaCadastroUsuario();
            this.Hide();
            cadastro.ShowDialog();
            if (cadastrado)
            {
                this.Show();
            }
        }
    }
}
