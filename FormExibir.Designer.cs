namespace LivroReceitasDigital
{
    partial class FormExibir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CorpoR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalvarR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CorpoR
            // 
            this.CorpoR.Location = new System.Drawing.Point(17, 138);
            this.CorpoR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CorpoR.Multiline = true;
            this.CorpoR.Name = "CorpoR";
            this.CorpoR.Size = new System.Drawing.Size(724, 564);
            this.CorpoR.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Corpo Receita";
            // 
            // NomeR
            // 
            this.NomeR.Location = new System.Drawing.Point(17, 45);
            this.NomeR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomeR.Name = "NomeR";
            this.NomeR.Size = new System.Drawing.Size(718, 31);
            this.NomeR.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Receita";
            // 
            // SalvarR
            // 
            this.SalvarR.Location = new System.Drawing.Point(564, 720);
            this.SalvarR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalvarR.Name = "SalvarR";
            this.SalvarR.Size = new System.Drawing.Size(173, 38);
            this.SalvarR.TabIndex = 8;
            this.SalvarR.Text = "Salvar Mudanças";
            this.SalvarR.UseVisualStyleBackColor = true;
            this.SalvarR.Click += new System.EventHandler(this.SalvarR_Click);
            // 
            // FormExibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 778);
            this.Controls.Add(this.SalvarR);
            this.Controls.Add(this.CorpoR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeR);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormExibir";
            this.Text = "FormExibir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CorpoR;
        private Label label2;
        private TextBox NomeR;
        private Label label1;
        private Button SalvarR;
    }
}