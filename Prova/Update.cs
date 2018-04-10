using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prova
{
    public partial class Update : Form
    {
        /*
           Informações do banco e tabela deste exemplo:
        * Banco: biblioteca;
        *      tabela: livros;
        *          campos: nome nvarchar(50), autor nvarchar(50); 
        */

        /* STRING DE CONEXAO, VEJA SE TEM O PROVIDER, SE TIVER, EXCLUA, VEJA TAMBEM SE TEM Password, se nao coloque assim: 'Password=info211;' sem aspas e cuidado com o ponto e virgula */
        SqlConnection conn = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=biblioteca;Data Source=TARDIS-PC");
        public Update()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = 0;//variavel para pegar o id para mudar na tabela usando where tabela.id = programa.id;
            try //isso é feito para tentar fazer alguma coisa que pode dar erro, e caso de erro ele vai pro catch
            {
                id = int.Parse(txtId.Text);//como id é do tipo int, se alguem colocar uma String por engano ele 
                String sql = "update livros set nome = '" + txtNome.Text + "', autor = '" + txtAutor.Text + "' where pk_idLivro = " + id; //sql para update
                SqlCommand comando = new SqlCommand(sql, conn); //comando
                conn.Open(); //abrindo conexao
                comando.ExecuteNonQuery(); //executando a query sem retornar nada
                conn.Close(); //fechando a conexao
                MessageBox.Show("Salvou");//Alerta se salvou as mudanças
            }
            catch (Exception)
            {
                MessageBox.Show("Try deu erro"); //alerta caso de erro no try
            }
        }

        private void btnId_Click(object sender, EventArgs e)
        {

            String sql = "select * from livros where pk_idLivro = '" + txtId.Text + "'"; //sql para pesquisar pelo id
            conn.Open(); //abrindo conexao
            SqlCommand comando = new SqlCommand(sql, conn); //comando
            SqlDataReader data = comando.ExecuteReader(); //quando for receber dados do banco salvar em um SqlDataReader
            data.Read(); // Comando que tem que usar para ler proxima sequencia de dados, mas aqui só vai ter 1
            txtNome.Text = data.GetString(1); //para pegar os dados do dataReader vc tem que usar o metodo GetString(i); onde o primeiro dado começa pelo 1
            txtAutor.Text = data.GetString(2); // pegando a secunda coluna que é autor
            conn.Close(); //fechando a conexao 

        }
    }
}
