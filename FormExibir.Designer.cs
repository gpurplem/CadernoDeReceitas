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
            this.SuspendLayout();
            // 
            // CorpoR
            // 
            this.CorpoR.Location = new System.Drawing.Point(12, 83);
            this.CorpoR.Multiline = true;
            this.CorpoR.Name = "CorpoR";
            this.CorpoR.Size = new System.Drawing.Size(508, 340);
            this.CorpoR.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Corpo Receita";
            // 
            // NomeR
            // 
            this.NomeR.Location = new System.Drawing.Point(12, 27);
            this.NomeR.Name = "NomeR";
            this.NomeR.Size = new System.Drawing.Size(504, 23);
            this.NomeR.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Receita";
            // 
            // FormExibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.CorpoR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeR);
            this.Controls.Add(this.label1);
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
    }
}