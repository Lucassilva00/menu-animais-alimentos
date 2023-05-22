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

    public partial class altalimentos : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblalimentos;
        private SqlCommand comando;
        private string strsql, strconex;

        public altalimentos()
        {
            InitializeComponent();
        }

        private void Btpesquisar_Click(object sender, EventArgs e)
        {
            strconex = "data source=(local); initial catalog=Zoologico; integrated security = sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblalimentos = new DataTable();

            strsql = "select * from alimentos where codalimento = '" + txtcodalimento.Text + "'";

            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblalimentos);

            if (tblalimentos.Rows.Count == 1)
            {
                groupBox1.Enabled = false;
                groupBox2.Visible = true;

                txtalimento.Text = tblalimentos.Rows[0]["alimento"].ToString();
                txtdescricao.Text = tblalimentos.Rows[0]["descricao"].ToString();
                
            }
            else
            {
                MessageBox.Show("Registro não encontrado!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btgravar_Click(object sender, EventArgs e)
        {
            strsql = "update Alimentos set alimento = '" + txtalimento.Text + "', descricao= '" + txtdescricao.Text + "' where codalimento = '" + txtcodalimento.Text + "'";

            comando = new SqlCommand(strsql, conexao);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registro gravado com sucesso!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            groupBox1.Enabled = true;
            groupBox2.Visible = false;
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Visible = false;
        }

        private void Altalimentos_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Visible = false;
        }
    }
}
