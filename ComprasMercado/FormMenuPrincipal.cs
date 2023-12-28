using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasMercado
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            panelPrincipal.Visible = false;
        }

        private void MenuItemLocais_Click(object sender, EventArgs e)
        {
            PreparaCamposPainel("locais");
        }

        private void MenuItemUnidadeMedida_Click(object sender, EventArgs e)
        {
            PreparaCamposPainel("unidades");
        }

        private void MenuItemProdutos_Click(object sender, EventArgs e)
        {
            PreparaCamposPainel("produtos");
        }

        private void MenuItemCompras_Click(object sender, EventArgs e)
        {
            PreparaCamposPainel("compras");
        }

        private void PreparaCamposPainel(string itemMenu)
        {
            try
            {
                //Verifica qual opção do menu foi selecionada.
                if (itemMenu == "locais" || itemMenu == "unidades" || itemMenu == "produtos" || itemMenu == "compras")
                {
                    //Torna visível apenas os componentes que serão utilizados.
                    panelPrincipal.Visible = true;
                    lblCodigo.Visible = true;
                    txtCodigo.Visible = true;
                    lblDescricao.Visible = true;
                    txtDescricao.Visible = true;
                    lblDataCompra.Visible = false;
                    CalendarDataCompra.Visible = false;
                    lblCbo1.Visible = false;
                    cbo1.Visible = false;
                    lblCbo2.Visible = false;
                    cbo2.Visible = false;
                    lblCbo3.Visible = false;
                    cbo3.Visible = false;
                    lblQuantidade.Visible = false;
                    txtQuantidade.Visible = false;
                    lblValorCompra.Visible = false;
                    txtValorCompra.Visible = false;
                    if (itemMenu == "produtos" || itemMenu == "compras")
                    {
                        lblCbo3.Visible = true;
                        cbo3.Visible = true;
                    }
                    if (itemMenu == "compras")
                    {
                        lblDataCompra.Visible = true;
                        CalendarDataCompra.Visible = true;
                        lblCbo1.Visible = true;
                        cbo1.Visible = true;
                        lblValorCompra.Visible = true;
                        txtValorCompra.Visible = true;
                        lblCbo2.Visible = true;
                        cbo2.Visible = true;
                        lblQuantidade.Visible = true;
                        txtQuantidade.Visible = true;
                    }

                    //Desabilita os componentes necessários.
                    txtCodigo.Enabled = false;
                    txtDescricao.Enabled = false;
                    buttonSalvar.Enabled = false;
                    buttonCancelar.Enabled = false;
                    if (itemMenu == "produtos" || itemMenu == "compras")
                    {
                        cbo3.Enabled = false;
                    }
                    if (itemMenu == "compras")
                    {
                        cbo1.Enabled = false;
                        txtValorCompra.Enabled = false;
                        cbo2.Enabled = false;
                        txtQuantidade.Enabled = false;
                        CalendarDataCompra.Enabled = false;
                    }

                    //Defini o título do painel.
                    if (itemMenu == "locais")
                    {
                        lblTitulo.Text = "Cadastro de Locais";
                    }
                    else if (itemMenu == "unidades")
                    {
                        lblTitulo.Text = "Cadastro de Unidades de Medidas";
                    }
                    else if (itemMenu == "produtos")
                    {
                        lblTitulo.Text = "Cadastro de Produtos";
                    }
                    else if (itemMenu == "compras")
                    {
                        lblTitulo.Text = "Cadastro de Compras";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
