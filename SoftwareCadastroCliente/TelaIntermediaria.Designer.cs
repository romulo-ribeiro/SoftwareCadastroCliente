namespace SoftwareCadastroCliente
{
    partial class TelaIntermediaria
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
            this.Btn_VaiParaCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_VaiParaCliente
            // 
            this.Btn_VaiParaCliente.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_VaiParaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_VaiParaCliente.Location = new System.Drawing.Point(110, 102);
            this.Btn_VaiParaCliente.Name = "Btn_VaiParaCliente";
            this.Btn_VaiParaCliente.Size = new System.Drawing.Size(415, 43);
            this.Btn_VaiParaCliente.TabIndex = 0;
            this.Btn_VaiParaCliente.Text = "Cadastrar Cliente";
            this.Btn_VaiParaCliente.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(415, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cadastrar Endereço";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(415, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cadastrar Usuário";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem-Vindo! O que você quer fazer hoje??";
            // 
            // TelaIntermediaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_VaiParaCliente);
            this.Name = "TelaIntermediaria";
            this.Text = "TelaIntermediaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_VaiParaCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}