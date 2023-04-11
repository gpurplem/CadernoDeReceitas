namespace LivroReceitasDigital
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvListaReceitas = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPesquisaTitulo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textPesquisaIngrediente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdPesquisaFacil = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisarDificuldade = new System.Windows.Forms.Button();
            this.rdPesquisaDificil = new System.Windows.Forms.RadioButton();
            this.rdPesquisaMedia = new System.Windows.Forms.RadioButton();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaReceitas
            // 
            this.dgvListaReceitas.AllowUserToAddRows = false;
            this.dgvListaReceitas.AllowUserToDeleteRows = false;
            this.dgvListaReceitas.AutoGenerateColumns = false;
            this.dgvListaReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaReceitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn});
            this.dgvListaReceitas.DataSource = this.receitaBindingSource;
            this.dgvListaReceitas.Location = new System.Drawing.Point(12, 151);
            this.dgvListaReceitas.Name = "dgvListaReceitas";
            this.dgvListaReceitas.ReadOnly = true;
            this.dgvListaReceitas.RowHeadersWidth = 62;
            this.dgvListaReceitas.RowTemplate.Height = 33;
            this.dgvListaReceitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaReceitas.Size = new System.Drawing.Size(776, 310);
            this.dgvListaReceitas.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 700;
            // 
            // receitaBindingSource
            // 
            this.receitaBindingSource.DataSource = typeof(LivroReceitasDigital.Receita);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(304, 467);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(200, 60);
            this.btnCriar.TabIndex = 1;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(587, 467);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(200, 60);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(9, 467);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(200, 60);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluirClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar por título";
            // 
            // textPesquisaTitulo
            // 
            this.textPesquisaTitulo.Location = new System.Drawing.Point(231, 6);
            this.textPesquisaTitulo.Name = "textPesquisaTitulo";
            this.textPesquisaTitulo.Size = new System.Drawing.Size(438, 31);
            this.textPesquisaTitulo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textPesquisaIngrediente
            // 
            this.textPesquisaIngrediente.Location = new System.Drawing.Point(231, 55);
            this.textPesquisaIngrediente.Name = "textPesquisaIngrediente";
            this.textPesquisaIngrediente.Size = new System.Drawing.Size(438, 31);
            this.textPesquisaIngrediente.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pesquisar por ingrediente";
            // 
            // rdPesquisaFacil
            // 
            this.rdPesquisaFacil.AutoSize = true;
            this.rdPesquisaFacil.Location = new System.Drawing.Point(3, 6);
            this.rdPesquisaFacil.Name = "rdPesquisaFacil";
            this.rdPesquisaFacil.Size = new System.Drawing.Size(70, 29);
            this.rdPesquisaFacil.TabIndex = 10;
            this.rdPesquisaFacil.TabStop = true;
            this.rdPesquisaFacil.Text = "Fácil";
            this.rdPesquisaFacil.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPesquisarDificuldade);
            this.panel1.Controls.Add(this.rdPesquisaDificil);
            this.panel1.Controls.Add(this.rdPesquisaMedia);
            this.panel1.Controls.Add(this.rdPesquisaFacil);
            this.panel1.Location = new System.Drawing.Point(402, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 53);
            this.panel1.TabIndex = 11;
            // 
            // btnPesquisarDificuldade
            // 
            this.btnPesquisarDificuldade.Location = new System.Drawing.Point(269, 6);
            this.btnPesquisarDificuldade.Name = "btnPesquisarDificuldade";
            this.btnPesquisarDificuldade.Size = new System.Drawing.Size(112, 34);
            this.btnPesquisarDificuldade.TabIndex = 12;
            this.btnPesquisarDificuldade.Text = "Pesquisar";
            this.btnPesquisarDificuldade.UseVisualStyleBackColor = true;
            this.btnPesquisarDificuldade.Click += new System.EventHandler(this.btnPesquisarDificuldade_Click);
            // 
            // rdPesquisaDificil
            // 
            this.rdPesquisaDificil.AutoSize = true;
            this.rdPesquisaDificil.Location = new System.Drawing.Point(171, 6);
            this.rdPesquisaDificil.Name = "rdPesquisaDificil";
            this.rdPesquisaDificil.Size = new System.Drawing.Size(80, 29);
            this.rdPesquisaDificil.TabIndex = 12;
            this.rdPesquisaDificil.TabStop = true;
            this.rdPesquisaDificil.Text = "Difícil";
            this.rdPesquisaDificil.UseVisualStyleBackColor = true;
            // 
            // rdPesquisaMedia
            // 
            this.rdPesquisaMedia.AutoSize = true;
            this.rdPesquisaMedia.Location = new System.Drawing.Point(79, 6);
            this.rdPesquisaMedia.Name = "rdPesquisaMedia";
            this.rdPesquisaMedia.Size = new System.Drawing.Size(86, 29);
            this.rdPesquisaMedia.TabIndex = 11;
            this.rdPesquisaMedia.TabStop = true;
            this.rdPesquisaMedia.Text = "Média";
            this.rdPesquisaMedia.UseVisualStyleBackColor = true;
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Location = new System.Drawing.Point(12, 92);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(384, 47);
            this.btnLimparPesquisa.TabIndex = 12;
            this.btnLimparPesquisa.Text = "Limpar Pesquisa";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btnLimparPesquisa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textPesquisaIngrediente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPesquisaTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.dgvListaReceitas);
            this.Name = "FormPrincipal";
            this.Text = "Caderno de Receitas";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvListaReceitas;
        private Button btnCriar;
        private Button btnAbrir;
        private Button btnExcluir;
        private BindingSource receitaBindingSource;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private Label label1;
        private TextBox textPesquisaTitulo;
        private Button button1;
        private Button button2;
        private TextBox textPesquisaIngrediente;
        private Label label2;
        private RadioButton rdPesquisaFacil;
        private Panel panel1;
        private Button btnPesquisarDificuldade;
        private RadioButton rdPesquisaDificil;
        private RadioButton rdPesquisaMedia;
        private Button btnLimparPesquisa;
    }
}