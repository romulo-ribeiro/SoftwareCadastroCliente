﻿using Negócios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareCadastroCliente
{
    public partial class TelaCadastroUsuario : Form
    {
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        { 
            UsuarioDados dados = new UsuarioDados();
            UsuarioModel cadastro = new UsuarioModel()
            {
                Usuario = txt_Usuario.Text,
                Senha = txt_Senha.Text,
            };
            dados.Create(cadastro);
            this.Close();
        }
    }
}
