using MySql.Data.MySqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComprasMercado
{
    internal class BancoDeDados
    {
        private string _nomeBanco = "comprasmercado";
        private string _usuarioBanco = "root";
        private string _senhaUsuario = "";
        private string _servidor = "localhost";
        private string _conexao = "";
        private MySqlConnection? _cn;
        private MySqlCommand? _comando;

        public MySqlCommand Comando
        {
            get { return _comando; }
            set { _comando = value; }
        }

        public MySqlConnection Cn
        {
            get { return _cn; }
        }

        public string NomeBanco
        {
            get { return _nomeBanco; }
        }

        public string UsuarioBanco
        {
            get { return _usuarioBanco; }
            set { _usuarioBanco = value; }
        }

        public string SenhaUsuario
        {
            get { return _senhaUsuario; }
            set { _senhaUsuario = value; }
        }

        public string Servidor
        {
            get { return _servidor; }
            set { _servidor = value; }
        }

        public string Conexao
        {
            get { return _conexao; }
        }

        Uteis uteis = new Uteis();

        public void ConectaDB(bool executaCriaTabelas)
        {
            try
            {
                if (_conexao == "")
                {
                    _conexao = ("server=" + _servidor
                        + ";uid=" + _usuarioBanco
                        + ";pwd=" + _senhaUsuario
                        + ";database=" + _nomeBanco);
                }
                _cn = new MySqlConnection(_conexao);
                _cn.Open();
                if (executaCriaTabelas == true)
                {
                    CriaTabelas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                _conexao = "";
            }
        }

        private void CriaTabelas()
        {
            try
            {
                _cn = new MySqlConnection(_conexao);
                _cn.Open();
                uteis.csql = "SELECT * FROM local limit 1";
                _comando = new MySqlCommand(uteis.csql, _cn);
                _comando.Prepare();
                var reader = _comando.ExecuteReader();

                //Verifica se existe algum registro na tabela 'local'.
                if (reader.Read() == true)
                {
                    reader.Close();
                    return;
                }
                //Se não existir, cria as tabelas do banco de dados.
                else
                {
                    reader.Close();
                    //Cria tabela 'local'.
                    uteis.csql = "CREATE TABLE IF NOT EXISTS comprasmercado.local (" +
                        "idlocal INT NOT NULL," +
                        "nomelocal VARCHAR(100) NULL," +
                        "PRIMARY KEY (idlocal))" +
                        " ENGINE = InnoDB";
                    _comando = new MySqlCommand(uteis.csql, _cn);
                    _comando.Prepare();
                    _comando.ExecuteNonQuery();
                    //Cria tabela 'unidademedida'.
                    uteis.csql = "CREATE TABLE IF NOT EXISTS comprasmercado.unidademedida (" +
                    "idunidademedida INT NOT NULL," +
                    "nomeunidademedida VARCHAR(100) NULL," +
                    "PRIMARY KEY (idunidademedida))" +
                    " ENGINE = InnoDB";
                    _comando = new MySqlCommand(uteis.csql, _cn);
                    _comando.Prepare();
                    _comando.ExecuteNonQuery();
                    //Cria tabela 'produto.
                    uteis.csql = "CREATE TABLE IF NOT EXISTS comprasmercado.produto (" +
                        "idproduto INT NOT NULL," +
                        "nomeproduto VARCHAR(100) NULL," +
                        "unidademedida_idunidademedida INT NOT NULL," +
                        "PRIMARY KEY (idproduto, unidademedida_idunidademedida)," +
                        "INDEX fk_produto_unidademedida1_idx (unidademedida_idunidademedida ASC)," +
                        "CONSTRAINT fk_produto_unidademedida1" +
                        " FOREIGN KEY (unidademedida_idunidademedida)" +
                        " REFERENCES comprasmercado.unidademedida (idunidademedida)" +
                        " ON DELETE NO ACTION" +
                        " ON UPDATE NO ACTION)" +
                        " ENGINE = InnoDB";
                    _comando = new MySqlCommand(uteis.csql, _cn);
                    _comando.Prepare();
                    _comando.ExecuteNonQuery();
                    //Cria tabela 'compraproduto'.
                    uteis.csql = "CREATE TABLE IF NOT EXISTS comprasmercado.compraproduto (" +
                        "idcompraproduto INT NOT NULL," +
                        "datacompraproduto DATE NULL," +
                        "local_idlocal INT NOT NULL," +
                        "precoproduto DECIMAL(16,2) NULL," +
                        "quantidadeproduto DECIMAL(16,2) NULL," +
                        "produto_idproduto INT NOT NULL," +
                        "produto_unidademedida_idunidademedida INT NOT NULL," +
                        "PRIMARY KEY (idcompraproduto, local_idlocal, produto_idproduto, produto_unidademedida_idunidademedida)," +
                        " INDEX fk_compra_local_idx (local_idlocal ASC)," +
                        " INDEX fk_compraproduto_produto1_idx (produto_idproduto ASC, produto_unidademedida_idunidademedida ASC)," +
                        " CONSTRAINT fk_compra_local" +
                        " FOREIGN KEY (local_idlocal)" +
                        " REFERENCES comprasmercado.local (idlocal)" +
                        " ON DELETE NO ACTION" +
                        " ON UPDATE NO ACTION," +
                        "CONSTRAINT fk_compraproduto_produto1" +
                        " FOREIGN KEY (produto_idproduto , produto_unidademedida_idunidademedida)" +
                        " REFERENCES comprasmercado.produto (idproduto , unidademedida_idunidademedida)" +
                        " ON DELETE NO ACTION" +
                        " ON UPDATE NO ACTION)" +
                        " ENGINE = InnoDB";
                    _comando = new MySqlCommand(uteis.csql, _cn);
                    _comando.Prepare();
                    _comando.ExecuteNonQuery();
                }
                _cn.Close();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Table 'comprasmercado.local' doesn't exist")
                {
                    goto CriaTabelas;
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                };
            //Cria as tabelas do banco de dados.
            CriaTabelas:
                _cn = new MySqlConnection(_conexao);
                _cn.Open();
                //Cria tabela 'local'.
                uteis.csql = "CREATE TABLE IF NOT EXISTS comprasmercado.local (" +
                    "idlocal INT NOT NULL," +
                    "nomelocal VARCHAR(100) NULL," +
                    "PRIMARY KEY (idlocal))" +
                    " ENGINE = InnoDB";
                _comando = new MySqlCommand(uteis.csql, _cn);
                _comando.Prepare();
                _comando.ExecuteNonQuery();
                //Cria tabela 'unidademedida'.
                uteis.csql = "CREATE TABLE IF NOT EXISTS comprasmercado.unidademedida (" +
                "idunidademedida INT NOT NULL," +
                "nomeunidademedida VARCHAR(100) NULL," +
                "PRIMARY KEY (idunidademedida))" +
                " ENGINE = InnoDB";
                _comando = new MySqlCommand(uteis.csql, _cn);
                _comando.Prepare();
                _comando.ExecuteNonQuery();
                //Cria tabela 'produto.
                uteis.csql = "CREATE TABLE IF NOT EXISTS comprasmercado.produto (" +
                    "idproduto INT NOT NULL," +
                    "nomeproduto VARCHAR(100) NULL," +
                    "unidademedida_idunidademedida INT NOT NULL," +
                    "PRIMARY KEY (idproduto, unidademedida_idunidademedida)," +
                    "INDEX fk_produto_unidademedida1_idx (unidademedida_idunidademedida ASC)," +
                    "CONSTRAINT fk_produto_unidademedida1" +
                    " FOREIGN KEY (unidademedida_idunidademedida)" +
                    " REFERENCES comprasmercado.unidademedida (idunidademedida)" +
                    " ON DELETE NO ACTION" +
                    " ON UPDATE NO ACTION)" +
                    " ENGINE = InnoDB";
                _comando = new MySqlCommand(uteis.csql, _cn);
                _comando.Prepare();
                _comando.ExecuteNonQuery();
                //Cria tabela 'compraproduto'.
                uteis.csql = "CREATE TABLE IF NOT EXISTS comprasmercado.compraproduto (" +
                    "idcompraproduto INT NOT NULL," +
                    "datacompraproduto DATE NULL," +
                    "local_idlocal INT NOT NULL," +
                    "precoproduto DECIMAL(16,2) NULL," +
                    "quantidadeproduto DECIMAL(16,2) NULL," +
                    "produto_idproduto INT NOT NULL," +
                    "produto_unidademedida_idunidademedida INT NOT NULL," +
                    "PRIMARY KEY (idcompraproduto, local_idlocal, produto_idproduto, produto_unidademedida_idunidademedida)," +
                    " INDEX fk_compra_local_idx (local_idlocal ASC)," +
                    " INDEX fk_compraproduto_produto1_idx (produto_idproduto ASC, produto_unidademedida_idunidademedida ASC)," +
                    " CONSTRAINT fk_compra_local" +
                    " FOREIGN KEY (local_idlocal)" +
                    " REFERENCES comprasmercado.local (idlocal)" +
                    " ON DELETE NO ACTION" +
                    " ON UPDATE NO ACTION," +
                    "CONSTRAINT fk_compraproduto_produto1" +
                    " FOREIGN KEY (produto_idproduto , produto_unidademedida_idunidademedida)" +
                    " REFERENCES comprasmercado.produto (idproduto , unidademedida_idunidademedida)" +
                    " ON DELETE NO ACTION" +
                    " ON UPDATE NO ACTION)" +
                    " ENGINE = InnoDB";
                _comando = new MySqlCommand(uteis.csql, _cn);
                _comando.Prepare();
                _comando.ExecuteNonQuery();
                _cn.Close();
            }
        }
    }

}
