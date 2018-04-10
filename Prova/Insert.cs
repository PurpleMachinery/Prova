using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Prova
{
    public partial class Insert : Form
    {
        /*
            Informações do banco e tabela deste exemplo:
         * Banco: biblioteca;
         *      tabela: livros;
         *          campos: nome nvarchar(50), autor nvarchar(50); 
         */

        /* STRING DE CONEXAO, VEJA SE TEM O PROVIDER, SE TIVER, EXCLUA, VEJA TAMBEM SE TEM Password, se nao coloque assim: 'Password=info211;' sem aspas e cuidado com o ponto e virgula */
        SqlConnection conn = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=biblioteca;Data Source=TARDIS-PC");
        public Insert()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e) /* METODO PARA LIMPAR OS CAMPOS PELO BOTAO LIMPAR */
        {
            txtAutor.Text = ""; //TIRA TUDO DE DENTRO DE AUTOR
            txtNome.Text = "";//TIRA TUDO DE DENTRO DE NOME
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtAutor.Text == "" || txtNome.Text == "") /* Teste para ver se os campos estao preenchidos */
            {
                MessageBox.Show("Tem que estar tudo preenchido"); // Caixa de messagem caso algum campo esteja vazio
            }
            else /* Caso tudo esteja preenchido execute o sql */
            {
                String sql = "insert into livros (nome, autor) values ('" + txtNome.Text + "','" + txtAutor.Text + "')"; // A Query que vc quer fazer ou seja :: insert into TABELA (VALORES NA ORDEM QUE VOCE QUER) VALUES (VALOR1, VALOR2, VALOR3);
                SqlCommand comando = new SqlCommand(sql, conn); //cria o comando, tendo que colocar a query e a conneccao ao banco que é a variavel de conexao conn
                conn.Open(); //Abre a conexao com o banco pela conexao conn
                comando.ExecuteNonQuery(); //Executa um comando query sem ter retorno nenhum caso queira retorno de valores em um select se usa comando.ExecuteReader();
                conn.Close(); //NUNCA SE ESQUEÇA DE FECHAR A CONEXAO (IMAGINA QUE TEM UMA EXCLAMAÇÃO AQUI)(IMAGINA QUE TEM UMA EXCLAMAÇÃO AQUI)(IMAGINA QUE TEM UMA EXCLAMAÇÃO AQUI)
                
                //caso esteja dando algum erro de banco de dados tire o comentario da linha abaixo que ele vai dar um alerta com o que foi pro banco contanto que a string de conexao esteja funcionando e nenhum dos campos esteja em branco
                //MessageBox.Show(sql);
            }
        }
    }
}
