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
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).BeginInit();
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
            this.dgvListaReceitas.Location = new System.Drawing.Point(11, 12);
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
            this.btnCriar.Location = new System.Drawing.Point(306, 352);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(200, 60);
            this.btnCriar.TabIndex = 1;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(589, 352);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(200, 60);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.dgvListaReceitas);
            this.Name = "FormPrincipal";
            this.Text = "Caderno de Receitas";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvListaReceitas;
        private Button btnCriar;
        private Button btnAbrir;
        private Button button3;
        private BindingSource receitaBindingSource;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}