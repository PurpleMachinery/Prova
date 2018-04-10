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
    public partial class SelectTudo : Form
    {
        /*
            Informações do banco e tabela deste exemplo:
         * Banco: biblioteca;
         *      tabela: livros;
         *          campos: nome nvarchar(50), autor nvarchar(50); 
         */

        /* STRING DE CONEXAO, VEJA SE TEM O PROVIDER, SE TIVER, EXCLUA, VEJA TAMBEM SE TEM Password, se nao coloque assim: 'Password=info211;' sem aspas e cuidado com o ponto e virgula */
        SqlConnection conn = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=biblioteca;Data Source=TARDIS-PC");
        public SelectTudo()
        {
            InitializeComponent();
        }

        private void SelectTudo_Load(object sender, EventArgs e)
        {
            String sql = "select * from livros"; // a query
            SqlDataAdapter adapdator = new SqlDataAdapter(sql, conn); // tem que criar um adapdator para pegar os dados do banco de dados
            DataSet tabela = new DataSet(); // tem que criar um adapdator para pegar os dados do adapdator do banco
            conn.Open(); //abrir conexao
            adapdator.Fill(tabela); //o metodo fill pega os dados que o sql retorna e coloca na tabela


            dataLivros.DataSource = tabela; //vc tem que colocar o objeto de tabela grafica para receber os dados da tabela
            dataLivros.DataMember = tabela.Tables[0].TableName; // isso ele coloca os nomes das colunas pra voce sem precisar usar outros metodos

            conn.Close();
        }
    }
}
