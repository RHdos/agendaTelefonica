using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace agendaTelefonica.sqlServer
{
    public class adicionar
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JVPURML;Initial Catalog=agendaTelefonica;Integrated Security=True");
        public void adicionarContato(string nome, string tel1, string tel2, string email, string cep, string rua, string bairro, string cidade, string estado, string numero, string complemento)
        {
            //Cria string de busca sql
            string sql = "INSERT INTO contato(nome, telefone1, telefone2, email, cep, rua,bairro,cidade,estado,numero,complemento) VALUES(@nome, @tel1, @tel2, @email, @cep, @rua, @bairro, @cidade, @estado, @numero, @complemento)"; 

            try
            {
                //Cria um objeto do tipo comando passando como paramentro a string sql e conn
                SqlCommand c = new SqlCommand(sql, conn);

                //Insere os dados da textBox no comando sql
                c.Parameters.Add(new SqlParameter("@nome", nome));
                c.Parameters.Add(new SqlParameter("@tel1", tel1));
                c.Parameters.Add(new SqlParameter("@tel2", tel2));
                c.Parameters.Add(new SqlParameter("@email", email));
                c.Parameters.Add(new SqlParameter("@cep", cep));
                c.Parameters.Add(new SqlParameter("@rua", rua));
                c.Parameters.Add(new SqlParameter("@bairro", bairro));
                c.Parameters.Add(new SqlParameter("@cidade", cidade));
                c.Parameters.Add(new SqlParameter("@estado", estado));
                c.Parameters.Add(new SqlParameter("@numero", numero));
                c.Parameters.Add(new SqlParameter("@complemento", complemento));

                //Abrir conexao com o banco de dados
                conn.Open();

                //Executa o comando Sql no banco de dados
                c.ExecuteNonQuery();

                //Fechar conexao do banco de dados
                conn.Close();

                //Mensagem de Sucesso na Inserção
                MessageBox.Show("Contato adicionado com sucesso!!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
