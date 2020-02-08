using Correios;
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
using agendaTelefonica.sqlServer;

namespace agendaTelefonica
{
    public partial class adicionarContato : Form
    {
        public adicionarContato()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.txtTel1.Text == null && this.txtTel2.Text != null)
            {
                this.txtTel1.Text = this.txtTel2.Text;
                this.txtTel2.Text = "";
            }
                
            if (this.txtNome.Text!=null && this.txtTel1.Text != null) {
                adicionar add = new adicionar();
                add.adicionarContato(this.txtNome.Text, this.txtTel1.Text, this.txtTel2.Text, this.txtEmail.Text, this.txtCep.Text, this.txtRua.Text, this.txtBairro.Text, this.txtCidade.Text, this.txtEstado.Text, this.txtNumero.Text, this.txtComplemento.Text);
            }
            else
            {
                MessageBox.Show("Nome e/ou telefone não preenchidos!");
            }

        }
        //busca de endereço por CEP
        private void txtCep_Leave(object sender, EventArgs e)
        {
            var service = new CorreiosApi();
            var dados = service.consultaCEP(txtCep.Text);

            if (dados != null)
            {
                txtEstado.Text = dados.uf;
                txtCidade.Text = dados.cidade;
                txtBairro.Text = dados.bairro;
                txtRua.Text = dados.end;
            }
            else
            {
                MessageBox.Show("Cep não localizado...");
            }
        }
            
    }
}

