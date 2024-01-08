using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ComprasMercado
{
    public partial class FormMenuPrincipal : Form
    {

        BancoDeDados banco = new BancoDeDados();
        Uteis uteis = new Uteis();

        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        public FormMenuPrincipal(string servidor, string usuario, string senha) : this()
        {
            banco.Servidor = servidor;
            banco.UsuarioBanco = usuario;
            banco.SenhaUsuario = senha;
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

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            PreparaCamposParaAcaoAdicionar(lblTitulo.Text);
            CarregaProximoID("adicionar", lblTitulo.Text);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaPreenchimentoDosCampos(lblTitulo.Text) == true)
                {
                    int posicaoCaractere;
                    banco.ConectaDB(false);
                    uteis.csql = txtCodigo.Text + ",'" + txtDescricao.Text + "'";
                    if (lblTitulo.Text == "Cadastro de Locais")
                    {
                        banco.Comando = new MySqlCommand(uteis.MontaInsert("local", uteis.csql), banco.Cn);
                    }
                    if (lblTitulo.Text == "Cadastro de Unidades de Medidas")
                    {
                        banco.Comando = new MySqlCommand(uteis.MontaInsert("unidademedida", uteis.csql), banco.Cn);
                    }
                    if (lblTitulo.Text == "Cadastro de Produtos")
                    {
                        posicaoCaractere = cbo3.SelectedItem.ToString().IndexOf("-");
                        uteis.csql = uteis.csql + ",'" +
                                                cbo3.SelectedItem.ToString().Substring(0, posicaoCaractere - 1).Trim()
                                                + "'";

                        banco.Comando = new MySqlCommand(uteis.MontaInsert("produto", uteis.csql), banco.Cn);
                    }
                    if (lblTitulo.Text == "Cadastro de Compras")
                    {
                        //CORRIGIR A AÇÃO DE ADICIONAR COMPRA. NAO PRECISA APARECER O CAMPO "DESCRIÇÃO" NA TELA
                        DateTime dataCompra = Convert.ToDateTime(CalendarDataCompra.SelectionStart.ToShortDateString());
                        uteis.csql = txtCodigo.Text + ",'" + dataCompra.Year.ToString() + "-" + dataCompra.Month.ToString() + "-" + dataCompra.Day.ToString() + "'";
                        posicaoCaractere = cbo1.SelectedItem.ToString().IndexOf("-");
                        uteis.csql = uteis.csql + "," +
                                                cbo1.SelectedItem.ToString().Substring(0, posicaoCaractere - 1).Trim()
                                                + ",'" +
                                                decimal.Parse(txtValorCompra.Text)
                                                + "','" +
                                                decimal.Parse(txtQuantidade.Text) + "'";
                        posicaoCaractere = cbo2.SelectedItem.ToString().IndexOf("-");
                        uteis.csql = uteis.csql + "," + cbo2.SelectedItem.ToString().Substring(0, posicaoCaractere - 1).Trim();
                        posicaoCaractere = cbo3.SelectedItem.ToString().IndexOf("-");
                        uteis.csql = uteis.csql + "," + cbo3.SelectedItem.ToString().Substring(0, posicaoCaractere - 1).Trim();

                        banco.Comando = new MySqlCommand(uteis.MontaInsert("compraproduto", uteis.csql), banco.Cn);
                    }
                    banco.Comando.Prepare();
                    //CORRIGIR
                    banco.Comando.ExecuteNonQuery();
                    banco.Cn.Close();
                    if (lblTitulo.Text == "Cadastro de Locais" || lblTitulo.Text == "Cadastro de Unidades de Medidas" || lblTitulo.Text == "Cadastro de Produtos")
                    {
                        MessageBox.Show("Registro salvo com sucesso!\n" +
                                        txtCodigo.Text + " - " + txtDescricao.Text);
                    }
                    else if (lblTitulo.Text == "Cadastro de Compras")
                    {
                        MessageBox.Show("Registro salvo com sucesso!\n" +
                                        txtCodigo.Text + " - " + cbo2.SelectedItem.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos antes de salvar o registro.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
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
                        lblDescricao.Visible = false;
                        txtDescricao.Visible = false;
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

        private void PreparaCamposParaAcaoAdicionar(string tituloPainel)
        {
            try
            {
                //Habilita e Limpa os campos que serão utilizados.
                if (tituloPainel == "Cadastro de Locais" || tituloPainel == "Cadastro de Unidades de Medidas" || tituloPainel == "Cadastro de Produtos" || tituloPainel == "Cadastro de Compras")
                {
                    txtCodigo.Enabled = false;
                    txtDescricao.Enabled = true;
                    txtDescricao.Text = "";
                    buttonSalvar.Enabled = true;
                    buttonCancelar.Enabled = true;
                    if (tituloPainel == "Cadastro de Produtos" || tituloPainel == "Cadastro de Compras")
                    {
                        cbo3.Enabled = true;
                        CarregaCombo(cbo3);
                    }
                    if (tituloPainel == "Cadastro de Compras")
                    {
                        cbo1.Enabled = true;
                        CarregaCombo(cbo1);
                        cbo2.Enabled = true;
                        CarregaCombo(cbo2);
                        txtQuantidade.Enabled = true;
                        txtValorCompra.Enabled = true;
                        CalendarDataCompra.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void CarregaProximoID(string botao, string tituloPainel)
        {
            try
            {
                //Verifica o botão que está sendo acionado no painel
                if (botao == "adicionar")
                {
                    banco.ConectaDB(false);

                    //Verifica o título do painel
                    if (tituloPainel == "Cadastro de Locais")
                    {
                        uteis.csql = uteis.MontaQuery("idlocal", "local", "", "idlocal DESC LIMIT 1");
                    }
                    else if (tituloPainel == "Cadastro de Unidades de Medidas")
                    {
                        uteis.csql = uteis.MontaQuery("idunidademedida", "unidademedida", "", "idunidademedida DESC LIMIT 1");
                    }
                    else if (tituloPainel == "Cadastro de Produtos")
                    {
                        uteis.csql = uteis.MontaQuery("idproduto", "produto", "", "idproduto DESC LIMIT 1");
                    }
                    else if (tituloPainel == "Cadastro de Compras")
                    {
                        uteis.csql = uteis.MontaQuery("idcompraproduto", "compraproduto", "", "idcompraproduto DESC LIMIT 1");
                    }

                    banco.Comando = new MySqlCommand(uteis.csql, banco.Cn);
                    banco.Comando.Prepare();
                    banco.Comando.ExecuteNonQuery();
                    var reader = banco.Comando.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        txtCodigo.Text = (reader.GetInt32(0) + 1).ToString();

                        if (tituloPainel == "Cadastro de Produtos" || tituloPainel == "Cadastro de Compras")
                        {
                            cbo3.SelectedIndex = -1;
                        }
                        if (tituloPainel == "Cadastro de Compras")
                        {
                            cbo1.SelectedIndex = 0;
                            cbo2.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        txtCodigo.Text = "1";
                        txtDescricao.Text = "";

                        if (tituloPainel == "Cadastro de Produtos" || tituloPainel == "Cadastro de Compras")
                        {
                            cbo3.SelectedIndex = -1;
                        }
                        if (tituloPainel == "Cadastro de Compras")
                        {
                            cbo1.SelectedIndex = 0;
                            cbo2.SelectedIndex = -1;
                        }
                        txtQuantidade.Text = "";
                        txtValorCompra.Text = "";

                    }
                    banco.Cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void CarregaCombo(ComboBox combo)
        {
            try
            {
                combo.Items.Clear();
                banco.ConectaDB(false);

                //Verifica o nome do ComboBox que vai ser preenchido
                if (combo.Name == "cbo1")
                {
                    banco.Comando = new MySqlCommand(uteis.MontaQuery("idlocal, nomelocal", "local", "", "idlocal"), banco.Cn);
                }
                else if (combo.Name == "cbo2")
                {
                    banco.Comando = new MySqlCommand(uteis.MontaQuery("idproduto, nomeproduto", "produto", "", "idproduto"), banco.Cn);
                }
                else if (combo.Name == "cbo3")
                {
                    banco.Comando = new MySqlCommand(uteis.MontaQuery("idunidademedida, nomeunidademedida", "unidademedida", "", "idunidademedida"), banco.Cn);
                }

                banco.Comando.Prepare();
                banco.Comando.ExecuteNonQuery();
                var reader = banco.Comando.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read() == true)
                    {
                        //Preenche o combo, seguindo o padrão "Código - Descrição"
                        combo.Items.Add(reader.GetInt32(0) + " - " + reader.GetString(1));
                    }
                    reader.NextResult();
                }
                banco.Cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private bool VerificaPreenchimentoDosCampos(string tituloPainel)
        {
            try
            {
                uteis.bAux = true;

                //Verifica o título do painel
                if (tituloPainel == "Cadastro de Locais" || tituloPainel == "Cadastro de Unidades de Medidas" || tituloPainel == "Cadastro de Produtos")
                {
                    if (txtCodigo.Text == "" || txtDescricao.Text == "") { uteis.bAux = false; }
                }
                if (tituloPainel == "Cadastro de Compras")
                {
                    if (txtCodigo.Text == "") { uteis.bAux = false; }
                }
                if (tituloPainel == "Cadastro de Produtos" || tituloPainel == "Cadastro de Compras")
                {
                    if (cbo3.SelectedIndex == -1) { uteis.bAux = false; }
                }
                if (tituloPainel == "Cadastro de Compras")
                {
                    if (cbo1.SelectedIndex == -1 || cbo2.SelectedIndex == -1 || txtQuantidade.Text == "" || txtValorCompra.Text == "") { uteis.bAux = false; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            return uteis.bAux;
        }
    }
}
