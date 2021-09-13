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

namespace ProjetoCadastro2
{
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando, aguarde";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    var sqlQuery = "SELECT * FROM  tb_Cadastro Where Nome like'%" + txtBuscar.Text +"%' Order by Nome";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    toolStripStatusLabel1.Text = "Conectado";
                    statusStrip1.Refresh();
                }

            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falha.";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro(0);
            frm.ShowDialog();


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void selecionarToolStripButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            FrmCadastro frm = new FrmCadastro(id);
            frm.ShowDialog();
        }

        private void excluirStripButton1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            FrmCadastro frm = new FrmCadastro(id, true);
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        void Clear()
        {
            dataGridView1.DataSource = null;

        }

        private void limparStripButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
  }

