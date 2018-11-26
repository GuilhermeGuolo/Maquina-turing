namespace Maquina_de_Turing
{
    partial class Maquina
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
            this.fitaText = new System.Windows.Forms.TextBox();
            this.datagrid_transicoes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Estados_finais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BotaoIniciar = new System.Windows.Forms.Button();
            this.comoFunciona = new System.Windows.Forms.Button();
            this.Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asterisco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_transicoes)).BeginInit();
            this.SuspendLayout();
            // 
            // fitaText
            // 
            this.fitaText.Location = new System.Drawing.Point(30, 25);
            this.fitaText.Name = "fitaText";
            this.fitaText.Size = new System.Drawing.Size(450, 20);
            this.fitaText.TabIndex = 0;
            this.fitaText.Text = ">";
            this.fitaText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // datagrid_transicoes
            // 
            this.datagrid_transicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_transicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inicial,
            this.Asterisco,
            this.branco,
            this.A,
            this.B});
            this.datagrid_transicoes.Location = new System.Drawing.Point(2, 133);
            this.datagrid_transicoes.Name = "datagrid_transicoes";
            this.datagrid_transicoes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_transicoes.Size = new System.Drawing.Size(515, 323);
            this.datagrid_transicoes.TabIndex = 2;
            this.datagrid_transicoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fita";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_Estados_finais
            // 
            this.textBox_Estados_finais.Location = new System.Drawing.Point(30, 68);
            this.textBox_Estados_finais.Name = "textBox_Estados_finais";
            this.textBox_Estados_finais.Size = new System.Drawing.Size(95, 20);
            this.textBox_Estados_finais.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Estado Final";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Mostrar Estados/Transições";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotaoIniciar
            // 
            this.BotaoIniciar.Location = new System.Drawing.Point(30, 97);
            this.BotaoIniciar.Name = "BotaoIniciar";
            this.BotaoIniciar.Size = new System.Drawing.Size(219, 30);
            this.BotaoIniciar.TabIndex = 16;
            this.BotaoIniciar.Text = "Iniciar Máquina";
            this.BotaoIniciar.UseVisualStyleBackColor = true;
            this.BotaoIniciar.Click += new System.EventHandler(this.BotaoIniciar_Maquina);
            // 
            // comoFunciona
            // 
            this.comoFunciona.Location = new System.Drawing.Point(270, 68);
            this.comoFunciona.Name = "comoFunciona";
            this.comoFunciona.Size = new System.Drawing.Size(154, 23);
            this.comoFunciona.TabIndex = 17;
            this.comoFunciona.Text = "Como funciona?";
            this.comoFunciona.UseVisualStyleBackColor = true;
            this.comoFunciona.Click += new System.EventHandler(this.comoFunciona_Click);
            // 
            // Inicial
            // 
            this.Inicial.HeaderText = ">";
            this.Inicial.Name = "Inicial";
            // 
            // Asterisco
            // 
            this.Asterisco.HeaderText = "*";
            this.Asterisco.Name = "Asterisco";
            // 
            // branco
            // 
            this.branco.HeaderText = " ";
            this.branco.Name = "branco";
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            // 
            // Maquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 453);
            this.Controls.Add(this.comoFunciona);
            this.Controls.Add(this.BotaoIniciar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Estados_finais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagrid_transicoes);
            this.Controls.Add(this.fitaText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Maquina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maquina de Turing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_transicoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fitaText;
        private System.Windows.Forms.DataGridView datagrid_transicoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Estados_finais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BotaoIniciar;
        private System.Windows.Forms.Button comoFunciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asterisco;
        private System.Windows.Forms.DataGridViewTextBoxColumn branco;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
    }
}

