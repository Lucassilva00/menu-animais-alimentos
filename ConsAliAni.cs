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
    public partial class ConsAliAni : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblalimentos, tblanimais;
        private string strsql, strconex;
        private int linha = 0;


        public ConsAliAni()
        {
            InitializeComponent();
        }

        private void Btpri_Click(object sender, EventArgs e)
        {
            linha = 0;
            Preencher();
        }

        private void Btant_Click(object sender, EventArgs e)
        {
            if (linha > 0)
            {
                linha--;
                Preencher();
            }
            else
            {
                MessageBox.Show("Primeiro Registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btpro_Click(object sender, EventArgs e)
        {
            if (linha < tblalimentos.Rows.Count - 1)
            {
                linha++;
                Preencher();
            }
            else
            {
                MessageBox.Show("Último Registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btult_Click(object sender, EventArgs e)
        {
            linha = tblalimentos.Rows.Count - 1;
            Preencher();
        }

        private void ConsAliAni_Load(object sender, EventArgs e)
        {
            strconex = "data source=(local); initial catalog= zoologico; integrated security= sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblalimentos = new DataTable();

            strsql = "select * from Alimentos";

            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblalimentos);

            if (tblalimentos.Rows.Count != 0)
            {
                Preencher();
            }
            else
            {
                MessageBox.Show("Registro não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Preencher()
        {
            txtcodalimentos.Text = tblalimentos.Rows[linha]["codalimento"].ToString();
            txtalimentos.Text = tblalimentos.Rows[linha]["alimento"].ToString();
            txtdescricao.Text = tblalimentos.Rows[linha]["descricao"].ToString();

            tblanimais = new DataTable();

            strsql = "select * from Animais where codalimento = '" + txtcodalimentos.Text + "'";

            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblanimais);
            grade.DataSource = tblanimais;
            lblregistro.Text = (linha + 1).ToString() + " de " + tblalimentos.Rows.Count.ToString();
        }
    }
}
