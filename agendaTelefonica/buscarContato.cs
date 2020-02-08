using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace agendaTelefonica
{
    public partial class buscarContato : Form
    {
        public buscarContato()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtBuscarNome == null && this.txtBuscarTelefone == null)
            {
                MessageBox.Show("Por Favor Preencher o nome e/ou telefone");
            }
            else
            {
                //Criamos a string de conexao
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JVPURML;Initial Catalog=agendaTelefonica;Integrated Security=True");

                
                

                try
                {
                    //Cria um objeto do tipo comando passando como paramentro a string sql e conn

                    string sql = null;
                    if (this.txtBuscarNome != null && this.txtBuscarTelefone == null)
                    {
                        //Cria string de busca sql com o campo nome
                        sql = "SELECT * FROM contato WHERE nome LIKE %"+ this.txtBuscarNome +"%";

                    }
                    else
                    {
                        sql = "SELECT * FROM contato WHERE telefone1 LIKE %" + this.txtBuscarTelefone + "%";
                    }

                    SqlCommand c = new SqlCommand(sql, conn);


                    SqlDataReader resp = c.ExecuteReader();

                    //Retorna os dados do sql no list box
                    this.txtNome.Text = Convert.ToString(resp["nome"]);
                    this.txtTel1.Text = Convert.ToString(resp["telefone1"]);
                    this.txtTel2.Text = Convert.ToString(resp["telefone2"]);
                    this.txtEmail.Text = Convert.ToString(resp["email"]);
                    this.txtCep.Text = Convert.ToString(resp["cep"]);
                    this.txtRua.Text = Convert.ToString(resp["rua"]);
                    this.txtBairro.Text = Convert.ToString(resp["bairro"]);
                    this.txtCidade.Text = Convert.ToString(resp["cidade"]);
                    this.txtEstado.Text = Convert.ToString(resp["Estado"]);
                    this.txtNumero.Text = Convert.ToString(resp["numero"]);
                    this.txtComplemento.Text = Convert.ToString(resp["complemento"]);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
