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
    public partial class FrmCadastro : Form
    {
        int id = 0;
        public FrmCadastro(int id)
        {
            InitializeComponent();
            this.id = id;

            if (this.id > 0)
            {
                GetCadastro(id);
                toolStripButton1.Visible = true;
                excluircadasrtoStripButton1.Visible = false;
                limparStripButton2.Visible = false;

            }
            else
            {
                limparStripButton2.Visible = true;
                excluircadasrtoStripButton1.Visible = false;
            }
        }
        public FrmCadastro(int id, bool excluir)
        {
            InitializeComponent();
            this.id = id;

            if (excluir)
                if (this.id > 0)
                {
                    GetCadastro(id);
                    TravarControles();
                    toolStripButton1.Visible = false;
                    excluircadasrtoStripButton1.Visible = true;
                    limparStripButton2.Visible = false;

                }
                else
                    this.Close();
        }
        private void TravarControles()
        {
            txtNome.Enabled = false;
            maskCpf.Enabled = false;
            maskT1.Enabled = false;
            maskT2.Enabled = false;
        }



        private void GetCadastro(int id)
        {
            ToolStripStatusLabel1.Text = "Conectando...";
            StatusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "Select * from tb_Cadastro Where id=" + id;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        ToolStripStatusLabel1.Text = "Buscando o(a) Colaborador(a)...";
                        StatusStrip1.Refresh();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtNome.Text = dr["Nome"].ToString();
                                    maskCpf.Text = dr["Cpf"].ToString();
                                    maskT1.Text = dr["Telefone"].ToString();
                                    maskT2.Text = dr["Telefone2"].ToString();

                                }
                            }
                        }
                    }
                }
            }
            finally{
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
             
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            SalvarColaboradores();
            this.Close();
        }
        private void SalvarColaboradores()
        {
            ToolStripStatusLabel1.Text = "Conectando...";
            StatusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql ="";

                    if (this.id == 0)
                        sql = "INSERT INTO tb_Cadastro ( Nome, Cpf, Telefone, Telefone2) VALUES( @Nome, @Cpf, @Telefone, @Telefone2)";
                    else
                        sql = "UPDATE tb_Cadastro Set Nome=@Nome, Cpf=@Cpf, Telefone=@Telefone, Telefone2 = @Telefone2 WHERE id=" + this.id;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        ToolStripStatusLabel1.Text = "Salvando Colaborador.";
                        StatusStrip1.Refresh();

                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Cpf", maskCpf.Text);
                        cmd.Parameters.AddWithValue("@Telefone", maskT1.Text);
                        cmd.Parameters.AddWithValue("@Telefone2", maskT2.Text);
                        cmd.ExecuteNonQuery();
                    }
                    ToolStripStatusLabel1.Text = "Pronto.";
                    StatusStrip1.Refresh();
                }
            }
            catch (Exception ex)
            {
                ToolStripStatusLabel1.Text = "Falha";
                StatusStrip1.Refresh();
                MessageBox.Show("Não inserir os dados!\n\n" + ex.Message);
            }       
        }


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void excluircadasrtoStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja excluir:", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                ExcluirColaborador();
                this.Close();
            }
        }

        private void ExcluirColaborador()
        {
            ToolStripStatusLabel1.Text = "Conectando...";
            StatusStrip1.Refresh();

            try
            {
                using(SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "Delete from tb_Cadastro Where id=" + id;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        ToolStripStatusLabel1.Text = "Excluindo o(a) Colaborador(a).";
                        StatusStrip1.Refresh();

                        cmd.ExecuteNonQuery();
                    }
                    ToolStripStatusLabel1.Text = "Pronto.";
                    StatusStrip1.Refresh();
                }
            }
            catch(Exception ex)
            {
                ToolStripStatusLabel1.Text = "Falha";
                StatusStrip1.Refresh();
                MessageBox.Show("Falha ao excluir o(a) Colaborador(a)!\n\n" + ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

             

            if (ValidarForm())
            {
                DialogResult resp = MessageBox.Show("Deseja Salvar as Alterações?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MessageBox.Show("Salvo com Sucesso");
                SalvarColaboradores();
                this.Close();
            }
            
        }

        private void limparStripButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
             txtNome.Text = maskCpf.Text = maskT1.Text = maskT2.Text = "";

        }
        private bool ValidarForm()
        {
            bool FormValido;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o nome do Colaborador!");
                txtNome.Focus();
                FormValido = false;
            }
            else if (maskCpf.Text == "")
            {
                MessageBox.Show("Infore o CPF!");
                maskCpf.Focus();
                FormValido = false;
            }

            else if (maskT1.Text == "")
            {
                MessageBox.Show("Informe o Telefone!");
                maskT1.Focus();
                FormValido = false;
            }
            else
            {
                FormValido = true;
            }
            return FormValido;
        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void maskCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }

}
