using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_pavao
{
    public partial class cadalimentos : Form
    {
        private SqlConnection conexao;
        private SqlCommand comando;
        private string strsql, strconex;

        public cadalimentos()
        {
            InitializeComponent();
        }

        private void Btgravar_Click(object sender, EventArgs e)
        {
            try
            {
                strconex = "data source= (local); initial catalog=Zoologico;integrated security=sspi";
                conexao = new SqlConnection(strconex);
                conexao.Open();

                strsql = "insert into Alimentos (Alimento, Descricao) values ('" + txtalimento.Text + "', '" + txtdescricao.Text + "')";

                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();

                MessageBox.Show("Registro gravado com sucesso!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Verifique os valores!" + erro.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
