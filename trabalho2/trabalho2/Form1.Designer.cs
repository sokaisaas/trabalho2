namespace trabalho2
{
    partial class Form1
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
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cboservico = new System.Windows.Forms.ComboBox();
            this.data_lancamento = new System.Windows.Forms.DateTimePicker();
            this.chkpagamento = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnproximo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(927, 136);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(206, 22);
            this.txtpesquisa.TabIndex = 0;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(238, 177);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(148, 22);
            this.txtcodigo.TabIndex = 0;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(238, 223);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(148, 22);
            this.txtdescricao.TabIndex = 0;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(238, 266);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(148, 22);
            this.txtvalor.TabIndex = 0;
            // 
            // cbotipo
            // 
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(238, 304);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(121, 24);
            this.cbotipo.TabIndex = 1;
            // 
            // cboservico
            // 
            this.cboservico.FormattingEnabled = true;
            this.cboservico.Location = new System.Drawing.Point(238, 346);
            this.cboservico.Name = "cboservico";
            this.cboservico.Size = new System.Drawing.Size(121, 24);
            this.cboservico.TabIndex = 1;
            // 
            // data_lancamento
            // 
            this.data_lancamento.Location = new System.Drawing.Point(238, 401);
            this.data_lancamento.Name = "data_lancamento";
            this.data_lancamento.Size = new System.Drawing.Size(200, 22);
            this.data_lancamento.TabIndex = 2;
            // 
            // chkpagamento
            // 
            this.chkpagamento.AutoSize = true;
            this.chkpagamento.Font = new System.Drawing.Font("Proxy 1", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpagamento.ForeColor = System.Drawing.Color.Aqua;
            this.chkpagamento.Location = new System.Drawing.Point(238, 459);
            this.chkpagamento.Name = "chkpagamento";
            this.chkpagamento.Size = new System.Drawing.Size(117, 21);
            this.chkpagamento.TabIndex = 3;
            this.chkpagamento.Text = "checkBox1";
            this.chkpagamento.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(787, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 245);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.LightPink;
            this.btncadastrar.ForeColor = System.Drawing.Color.Cyan;
            this.btncadastrar.Location = new System.Drawing.Point(97, 510);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(122, 42);
            this.btncadastrar.TabIndex = 5;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.LightPink;
            this.btnok.ForeColor = System.Drawing.Color.Cyan;
            this.btnok.Location = new System.Drawing.Point(1139, 122);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(47, 36);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.button5_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.LightPink;
            this.btneditar.ForeColor = System.Drawing.Color.Cyan;
            this.btneditar.Location = new System.Drawing.Point(253, 510);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(122, 42);
            this.btneditar.TabIndex = 5;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.LightPink;
            this.btnexcluir.ForeColor = System.Drawing.Color.Cyan;
            this.btnexcluir.Location = new System.Drawing.Point(405, 510);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(122, 42);
            this.btnexcluir.TabIndex = 5;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnproximo
            // 
            this.btnproximo.BackColor = System.Drawing.Color.LightPink;
            this.btnproximo.ForeColor = System.Drawing.Color.Cyan;
            this.btnproximo.Location = new System.Drawing.Point(1193, 510);
            this.btnproximo.Name = "btnproximo";
            this.btnproximo.Size = new System.Drawing.Size(122, 42);
            this.btnproximo.TabIndex = 5;
            this.btnproximo.Text = "Próximo";
            this.btnproximo.UseVisualStyleBackColor = false;
            this.btnproximo.Click += new System.EventHandler(this.btnproximo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SWMono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(150, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SWMono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(115, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SWMono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(166, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SWMono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(130, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Serviço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("SWMono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(154, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("SWMono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(166, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("SWMono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(809, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pesquisa";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1376, 579);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnproximo);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkpagamento);
            this.Controls.Add(this.data_lancamento);
            this.Controls.Add(this.cboservico);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtpesquisa);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.ComboBox cboservico;
        private System.Windows.Forms.DateTimePicker data_lancamento;
        private System.Windows.Forms.CheckBox chkpagamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnproximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

