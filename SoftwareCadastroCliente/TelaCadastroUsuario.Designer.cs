namespace SoftwareCadastroCliente
{
    partial class TelaCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(23, 174);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(356, 34);
            this.txt_Senha.TabIndex = 13;
            this.txt_Senha.UseSystemPasswordChar = true;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(23, 70);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(356, 34);
            this.txt_Usuario.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Inserir Nova Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inserir Novo Usuário";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cadastrar.Location = new System.Drawing.Point(23, 241);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(356, 39);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // TelaCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 319);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cadastrar);
            this.Name = "TelaCadastroUsuario";
            this.Text = "Novo Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}