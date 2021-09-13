
namespace ProjetoCadastro2
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.limparStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.maskT2 = new System.Windows.Forms.MaskedTextBox();
            this.maskT1 = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.LabelCoT1 = new System.Windows.Forms.Label();
            this.LabelCoCpf = new System.Windows.Forms.Label();
            this.LabelCoNome = new System.Windows.Forms.Label();
            this.LabelT2 = new System.Windows.Forms.Label();
            this.LabelT1 = new System.Windows.Forms.Label();
            this.LabelCpf = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.excluircadasrtoStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.maskCpf = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.excluircadasrtoStripButton1,
            this.toolStripSeparator2,
            this.limparStripButton2,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(468, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // limparStripButton2
            // 
            this.limparStripButton2.ForeColor = System.Drawing.Color.Black;
            this.limparStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("limparStripButton2.Image")));
            this.limparStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.limparStripButton2.Name = "limparStripButton2";
            this.limparStripButton2.Size = new System.Drawing.Size(64, 22);
            this.limparStripButton2.Text = "&Limpar";
            this.limparStripButton2.Click += new System.EventHandler(this.limparStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // maskT2
            // 
            this.maskT2.BackColor = System.Drawing.Color.AliceBlue;
            this.maskT2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskT2.Location = new System.Drawing.Point(118, 298);
            this.maskT2.Mask = "(00) 00000-0000";
            this.maskT2.Name = "maskT2";
            this.maskT2.Size = new System.Drawing.Size(143, 19);
            this.maskT2.TabIndex = 4;
            this.maskT2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskT1
            // 
            this.maskT1.BackColor = System.Drawing.Color.AliceBlue;
            this.maskT1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskT1.Location = new System.Drawing.Point(118, 247);
            this.maskT1.Mask = "(00) 00000-0000";
            this.maskT1.Name = "maskT1";
            this.maskT1.Size = new System.Drawing.Size(140, 19);
            this.maskT1.TabIndex = 3;
            this.maskT1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(118, 139);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(303, 19);
            this.txtNome.TabIndex = 1;
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // LabelCoT1
            // 
            this.LabelCoT1.AutoSize = true;
            this.LabelCoT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCoT1.ForeColor = System.Drawing.Color.Red;
            this.LabelCoT1.Location = new System.Drawing.Point(133, 269);
            this.LabelCoT1.Name = "LabelCoT1";
            this.LabelCoT1.Size = new System.Drawing.Size(119, 15);
            this.LabelCoT1.TabIndex = 24;
            this.LabelCoT1.Text = "* Campo Obrigatório";
            // 
            // LabelCoCpf
            // 
            this.LabelCoCpf.AutoSize = true;
            this.LabelCoCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCoCpf.ForeColor = System.Drawing.Color.Red;
            this.LabelCoCpf.Location = new System.Drawing.Point(133, 216);
            this.LabelCoCpf.Name = "LabelCoCpf";
            this.LabelCoCpf.Size = new System.Drawing.Size(119, 15);
            this.LabelCoCpf.TabIndex = 23;
            this.LabelCoCpf.Text = "* Campo Obrigatório";
            // 
            // LabelCoNome
            // 
            this.LabelCoNome.AutoSize = true;
            this.LabelCoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCoNome.ForeColor = System.Drawing.Color.Red;
            this.LabelCoNome.Location = new System.Drawing.Point(133, 161);
            this.LabelCoNome.Name = "LabelCoNome";
            this.LabelCoNome.Size = new System.Drawing.Size(119, 15);
            this.LabelCoNome.TabIndex = 22;
            this.LabelCoNome.Text = "* Campo Obrigatório";
            // 
            // LabelT2
            // 
            this.LabelT2.AutoSize = true;
            this.LabelT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelT2.ForeColor = System.Drawing.Color.White;
            this.LabelT2.Location = new System.Drawing.Point(37, 301);
            this.LabelT2.Name = "LabelT2";
            this.LabelT2.Size = new System.Drawing.Size(75, 16);
            this.LabelT2.TabIndex = 19;
            this.LabelT2.Text = "Telefone 2:";
            // 
            // LabelT1
            // 
            this.LabelT1.AutoSize = true;
            this.LabelT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelT1.ForeColor = System.Drawing.Color.White;
            this.LabelT1.Location = new System.Drawing.Point(47, 247);
            this.LabelT1.Name = "LabelT1";
            this.LabelT1.Size = new System.Drawing.Size(65, 16);
            this.LabelT1.TabIndex = 20;
            this.LabelT1.Text = "Telefone:";
            // 
            // LabelCpf
            // 
            this.LabelCpf.AutoSize = true;
            this.LabelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCpf.ForeColor = System.Drawing.Color.White;
            this.LabelCpf.Location = new System.Drawing.Point(68, 185);
            this.LabelCpf.Name = "LabelCpf";
            this.LabelCpf.Size = new System.Drawing.Size(44, 20);
            this.LabelCpf.TabIndex = 17;
            this.LabelCpf.Text = "CPF:";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.ForeColor = System.Drawing.Color.White;
            this.LabelNome.Location = new System.Drawing.Point(57, 139);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(55, 20);
            this.LabelNome.TabIndex = 15;
            this.LabelNome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 56);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastro de Colaboradores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 380);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(468, 22);
            this.StatusStrip1.TabIndex = 29;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.ToolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.ToolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton1.Text = "&Salvar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // excluircadasrtoStripButton1
            // 
            this.excluircadasrtoStripButton1.ForeColor = System.Drawing.Color.Black;
            this.excluircadasrtoStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("excluircadasrtoStripButton1.Image")));
            this.excluircadasrtoStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluircadasrtoStripButton1.Name = "excluircadasrtoStripButton1";
            this.excluircadasrtoStripButton1.Size = new System.Drawing.Size(62, 22);
            this.excluircadasrtoStripButton1.Text = "&Excluir";
            this.excluircadasrtoStripButton1.Click += new System.EventHandler(this.excluircadasrtoStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // maskCpf
            // 
            this.maskCpf.BackColor = System.Drawing.Color.AliceBlue;
            this.maskCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCpf.Location = new System.Drawing.Point(118, 185);
            this.maskCpf.Mask = "000,000,000-00";
            this.maskCpf.Name = "maskCpf";
            this.maskCpf.Size = new System.Drawing.Size(140, 19);
            this.maskCpf.TabIndex = 2;
            this.maskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskCpf_KeyPress);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 402);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.maskT2);
            this.Controls.Add(this.maskT1);
            this.Controls.Add(this.maskCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.LabelCoT1);
            this.Controls.Add(this.LabelCoCpf);
            this.Controls.Add(this.LabelCoNome);
            this.Controls.Add(this.LabelT2);
            this.Controls.Add(this.LabelT1);
            this.Controls.Add(this.LabelCpf);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton limparStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MaskedTextBox maskT2;
        private System.Windows.Forms.MaskedTextBox maskT1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label LabelCoT1;
        private System.Windows.Forms.Label LabelCoCpf;
        private System.Windows.Forms.Label LabelCoNome;
        private System.Windows.Forms.Label LabelT2;
        private System.Windows.Forms.Label LabelT1;
        private System.Windows.Forms.Label LabelCpf;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton excluircadasrtoStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MaskedTextBox maskCpf;
    }
}

