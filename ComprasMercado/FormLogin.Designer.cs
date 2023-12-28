namespace ComprasMercado
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            buttonLogin = new Button();
            pictureBoxLogin = new PictureBox();
            txtServidor = new TextBox();
            lblServidor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(247, 174);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(52, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(305, 171);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(225, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(255, 202);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(44, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(305, 199);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(225, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(377, 257);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources.logo;
            pictureBoxLogin.Location = new Point(346, 34);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(131, 131);
            pictureBoxLogin.TabIndex = 5;
            pictureBoxLogin.TabStop = false;
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(305, 228);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(225, 23);
            txtServidor.TabIndex = 7;
            txtServidor.Text = "localhost";
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServidor.ForeColor = Color.White;
            lblServidor.Location = new Point(241, 231);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(58, 15);
            lblServidor.TabIndex = 6;
            lblServidor.Text = "Servidor:";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(txtServidor);
            Controls.Add(lblServidor);
            Controls.Add(pictureBoxLogin);
            Controls.Add(buttonLogin);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Name = "FormLogin";
            Text = "Controle de Compras";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button buttonLogin;
        private PictureBox pictureBoxLogin;
        private TextBox txtServidor;
        private Label lblServidor;
    }
}
