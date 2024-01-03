namespace ComprasMercado
{
    partial class FormMenuPrincipal
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
            menuPrincipal = new MenuStrip();
            MenuItemCadastros = new ToolStripMenuItem();
            MenuItemLocais = new ToolStripMenuItem();
            MenuItemUnidadeMedida = new ToolStripMenuItem();
            MenuItemProdutos = new ToolStripMenuItem();
            MenuItemCompras = new ToolStripMenuItem();
            panelPrincipal = new Panel();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            txtValorCompra = new TextBox();
            lblValorCompra = new Label();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            cbo3 = new ComboBox();
            lblCbo3 = new Label();
            cbo2 = new ComboBox();
            lblCbo2 = new Label();
            cbo1 = new ComboBox();
            lblCbo1 = new Label();
            CalendarDataCompra = new MonthCalendar();
            lblDataCompra = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            panelCabecalho = new Panel();
            lblTitulo = new Label();
            panelLateral = new Panel();
            buttonPesquisar = new Button();
            buttonRemover = new Button();
            buttonAdicionar = new Button();
            menuPrincipal.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panelCabecalho.SuspendLayout();
            panelLateral.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Items.AddRange(new ToolStripItem[] { MenuItemCadastros });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(800, 24);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "Menu Principal";
            // 
            // MenuItemCadastros
            // 
            MenuItemCadastros.DropDownItems.AddRange(new ToolStripItem[] { MenuItemLocais, MenuItemUnidadeMedida, MenuItemProdutos, MenuItemCompras });
            MenuItemCadastros.Name = "MenuItemCadastros";
            MenuItemCadastros.Size = new Size(71, 20);
            MenuItemCadastros.Text = "Cadastros";
            // 
            // MenuItemLocais
            // 
            MenuItemLocais.Name = "MenuItemLocais";
            MenuItemLocais.Size = new Size(182, 22);
            MenuItemLocais.Text = "Locais";
            MenuItemLocais.Click += MenuItemLocais_Click;
            // 
            // MenuItemUnidadeMedida
            // 
            MenuItemUnidadeMedida.Name = "MenuItemUnidadeMedida";
            MenuItemUnidadeMedida.Size = new Size(182, 22);
            MenuItemUnidadeMedida.Text = "Unidades de Medida";
            MenuItemUnidadeMedida.Click += MenuItemUnidadeMedida_Click;
            // 
            // MenuItemProdutos
            // 
            MenuItemProdutos.Name = "MenuItemProdutos";
            MenuItemProdutos.Size = new Size(182, 22);
            MenuItemProdutos.Text = "Produtos";
            MenuItemProdutos.Click += MenuItemProdutos_Click;
            // 
            // MenuItemCompras
            // 
            MenuItemCompras.Name = "MenuItemCompras";
            MenuItemCompras.Size = new Size(182, 22);
            MenuItemCompras.Text = "Compras";
            MenuItemCompras.Click += MenuItemCompras_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.Controls.Add(buttonCancelar);
            panelPrincipal.Controls.Add(buttonSalvar);
            panelPrincipal.Controls.Add(txtValorCompra);
            panelPrincipal.Controls.Add(lblValorCompra);
            panelPrincipal.Controls.Add(txtQuantidade);
            panelPrincipal.Controls.Add(lblQuantidade);
            panelPrincipal.Controls.Add(cbo3);
            panelPrincipal.Controls.Add(lblCbo3);
            panelPrincipal.Controls.Add(cbo2);
            panelPrincipal.Controls.Add(lblCbo2);
            panelPrincipal.Controls.Add(cbo1);
            panelPrincipal.Controls.Add(lblCbo1);
            panelPrincipal.Controls.Add(CalendarDataCompra);
            panelPrincipal.Controls.Add(lblDataCompra);
            panelPrincipal.Controls.Add(txtDescricao);
            panelPrincipal.Controls.Add(lblDescricao);
            panelPrincipal.Controls.Add(txtCodigo);
            panelPrincipal.Controls.Add(lblCodigo);
            panelPrincipal.Controls.Add(panelCabecalho);
            panelPrincipal.Controls.Add(panelLateral);
            panelPrincipal.Location = new Point(0, 27);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(800, 422);
            panelPrincipal.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.DarkSlateGray;
            buttonCancelar.FlatAppearance.BorderColor = Color.DarkSlateGray;
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(699, 375);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(89, 36);
            buttonCancelar.TabIndex = 19;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.DarkSlateGray;
            buttonSalvar.FlatAppearance.BorderColor = Color.DarkSlateGray;
            buttonSalvar.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.Location = new Point(604, 375);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(89, 36);
            buttonSalvar.TabIndex = 18;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(212, 189);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(100, 23);
            txtValorCompra.TabIndex = 17;
            // 
            // lblValorCompra
            // 
            lblValorCompra.AutoSize = true;
            lblValorCompra.Location = new Point(108, 191);
            lblValorCompra.Name = "lblValorCompra";
            lblValorCompra.Size = new Size(98, 15);
            lblValorCompra.TabIndex = 16;
            lblValorCompra.Text = "Valor da Compra:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(393, 160);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(139, 23);
            txtQuantidade.TabIndex = 15;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(318, 163);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 14;
            lblQuantidade.Text = "Quantidade";
            // 
            // cbo3
            // 
            cbo3.FormattingEnabled = true;
            cbo3.Location = new Point(212, 160);
            cbo3.Name = "cbo3";
            cbo3.Size = new Size(100, 23);
            cbo3.TabIndex = 13;
            // 
            // lblCbo3
            // 
            lblCbo3.AutoSize = true;
            lblCbo3.Location = new Point(93, 163);
            lblCbo3.Name = "lblCbo3";
            lblCbo3.Size = new Size(113, 15);
            lblCbo3.TabIndex = 12;
            lblCbo3.Text = "Unidade de Medida:";
            // 
            // cbo2
            // 
            cbo2.FormattingEnabled = true;
            cbo2.Location = new Point(212, 131);
            cbo2.Name = "cbo2";
            cbo2.Size = new Size(320, 23);
            cbo2.TabIndex = 11;
            // 
            // lblCbo2
            // 
            lblCbo2.AutoSize = true;
            lblCbo2.Location = new Point(153, 134);
            lblCbo2.Name = "lblCbo2";
            lblCbo2.Size = new Size(53, 15);
            lblCbo2.TabIndex = 10;
            lblCbo2.Text = "Produto:";
            // 
            // cbo1
            // 
            cbo1.FormattingEnabled = true;
            cbo1.Location = new Point(212, 102);
            cbo1.Name = "cbo1";
            cbo1.Size = new Size(320, 23);
            cbo1.TabIndex = 9;
            // 
            // lblCbo1
            // 
            lblCbo1.AutoSize = true;
            lblCbo1.Location = new Point(168, 105);
            lblCbo1.Name = "lblCbo1";
            lblCbo1.Size = new Size(38, 15);
            lblCbo1.TabIndex = 8;
            lblCbo1.Text = "Local:";
            // 
            // CalendarDataCompra
            // 
            CalendarDataCompra.BackColor = SystemColors.Window;
            CalendarDataCompra.Location = new Point(564, 44);
            CalendarDataCompra.Name = "CalendarDataCompra";
            CalendarDataCompra.TabIndex = 7;
            // 
            // lblDataCompra
            // 
            lblDataCompra.AutoSize = true;
            lblDataCompra.Location = new Point(465, 47);
            lblDataCompra.Name = "lblDataCompra";
            lblDataCompra.Size = new Size(96, 15);
            lblDataCompra.TabIndex = 6;
            lblDataCompra.Text = "Data da Compra:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(212, 73);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(320, 23);
            txtDescricao.TabIndex = 5;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(145, 76);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(212, 44);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(157, 47);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código:";
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.Goldenrod;
            panelCabecalho.Controls.Add(lblTitulo);
            panelCabecalho.Location = new Point(0, 0);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(800, 41);
            panelCabecalho.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo da Página";
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.DarkSlateGray;
            panelLateral.Controls.Add(buttonPesquisar);
            panelLateral.Controls.Add(buttonRemover);
            panelLateral.Controls.Add(buttonAdicionar);
            panelLateral.Location = new Point(0, 41);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(87, 381);
            panelLateral.TabIndex = 0;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.BackColor = Color.DarkSlateGray;
            buttonPesquisar.FlatAppearance.BorderColor = Color.DarkSlateGray;
            buttonPesquisar.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonPesquisar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            buttonPesquisar.FlatStyle = FlatStyle.Flat;
            buttonPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesquisar.ForeColor = Color.White;
            buttonPesquisar.Location = new Point(0, 64);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(87, 23);
            buttonPesquisar.TabIndex = 2;
            buttonPesquisar.Text = "# Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = false;
            // 
            // buttonRemover
            // 
            buttonRemover.BackColor = Color.DarkSlateGray;
            buttonRemover.FlatAppearance.BorderColor = Color.DarkSlateGray;
            buttonRemover.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonRemover.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            buttonRemover.FlatStyle = FlatStyle.Flat;
            buttonRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemover.ForeColor = Color.White;
            buttonRemover.Location = new Point(0, 35);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(87, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "- Remover";
            buttonRemover.UseVisualStyleBackColor = false;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.DarkSlateGray;
            buttonAdicionar.FlatAppearance.BorderColor = Color.DarkSlateGray;
            buttonAdicionar.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonAdicionar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdicionar.ForeColor = Color.White;
            buttonAdicionar.Location = new Point(0, 6);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(87, 23);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "+ Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 449);
            Controls.Add(panelPrincipal);
            Controls.Add(menuPrincipal);
            MainMenuStrip = menuPrincipal;
            Name = "FormMenuPrincipal";
            Text = "Controle de Compras";
            Load += FormMenuPrincipal_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            panelLateral.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem MenuItemCadastros;
        private ToolStripMenuItem MenuItemLocais;
        private ToolStripMenuItem MenuItemUnidadeMedida;
        private ToolStripMenuItem MenuItemProdutos;
        private ToolStripMenuItem MenuItemCompras;
        private Panel panelPrincipal;
        private Panel panelLateral;
        private Panel panelCabecalho;
        private Label lblTitulo;
        private Button buttonAdicionar;
        private Button buttonRemover;
        private Button buttonPesquisar;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private Label lblDataCompra;
        private MonthCalendar CalendarDataCompra;
        private ComboBox cbo1;
        private Label lblCbo1;
        private ComboBox cbo2;
        private Label lblCbo2;
        private ComboBox cbo3;
        private Label lblCbo3;
        private TextBox txtValorCompra;
        private Label lblValorCompra;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}