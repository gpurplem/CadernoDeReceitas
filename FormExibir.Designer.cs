﻿namespace LivroReceitasDigital
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
            this.ingredientesR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalvarR = new System.Windows.Forms.Button();
            this.CorpoR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.autorR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelDificuldade = new System.Windows.Forms.Panel();
            this.rdDificil = new System.Windows.Forms.RadioButton();
            this.rdMedia = new System.Windows.Forms.RadioButton();
            this.rdFacil = new System.Windows.Forms.RadioButton();
            this.panelDificuldade.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingredientesR
            // 
            this.ingredientesR.Location = new System.Drawing.Point(30, 128);
            this.ingredientesR.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ingredientesR.Multiline = true;
            this.ingredientesR.Name = "ingredientesR";
            this.ingredientesR.Size = new System.Drawing.Size(714, 157);
            this.ingredientesR.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingredientes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomeR
            // 
            this.NomeR.Location = new System.Drawing.Point(30, 45);
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
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Título Receita";
            // 
            // SalvarR
            // 
            this.SalvarR.Location = new System.Drawing.Point(571, 707);
            this.SalvarR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalvarR.Name = "SalvarR";
            this.SalvarR.Size = new System.Drawing.Size(173, 38);
            this.SalvarR.TabIndex = 8;
            this.SalvarR.Text = "Salvar Mudanças";
            this.SalvarR.UseVisualStyleBackColor = true;
            this.SalvarR.Click += new System.EventHandler(this.SalvarR_Click);
            // 
            // CorpoR
            // 
            this.CorpoR.Location = new System.Drawing.Point(30, 341);
            this.CorpoR.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CorpoR.Multiline = true;
            this.CorpoR.Name = "CorpoR";
            this.CorpoR.Size = new System.Drawing.Size(714, 201);
            this.CorpoR.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modo Preparo";
            // 
            // autorR
            // 
            this.autorR.Location = new System.Drawing.Point(30, 599);
            this.autorR.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.autorR.Multiline = true;
            this.autorR.Name = "autorR";
            this.autorR.Size = new System.Drawing.Size(714, 51);
            this.autorR.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 566);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 672);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dificuldade";
            // 
            // panelDificuldade
            // 
            this.panelDificuldade.Controls.Add(this.rdDificil);
            this.panelDificuldade.Controls.Add(this.rdMedia);
            this.panelDificuldade.Controls.Add(this.rdFacil);
            this.panelDificuldade.Location = new System.Drawing.Point(30, 702);
            this.panelDificuldade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDificuldade.Name = "panelDificuldade";
            this.panelDificuldade.Size = new System.Drawing.Size(272, 42);
            this.panelDificuldade.TabIndex = 17;
            // 
            // rdDificil
            // 
            this.rdDificil.AutoSize = true;
            this.rdDificil.Location = new System.Drawing.Point(176, 5);
            this.rdDificil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdDificil.Name = "rdDificil";
            this.rdDificil.Size = new System.Drawing.Size(80, 29);
            this.rdDificil.TabIndex = 20;
            this.rdDificil.TabStop = true;
            this.rdDificil.Text = "Difícil";
            this.rdDificil.UseVisualStyleBackColor = true;
            // 
            // rdMedia
            // 
            this.rdMedia.AutoSize = true;
            this.rdMedia.Location = new System.Drawing.Point(82, 5);
            this.rdMedia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdMedia.Name = "rdMedia";
            this.rdMedia.Size = new System.Drawing.Size(86, 29);
            this.rdMedia.TabIndex = 19;
            this.rdMedia.TabStop = true;
            this.rdMedia.Text = "Média";
            this.rdMedia.UseVisualStyleBackColor = true;
            // 
            // rdFacil
            // 
            this.rdFacil.AutoSize = true;
            this.rdFacil.Location = new System.Drawing.Point(4, 2);
            this.rdFacil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdFacil.Name = "rdFacil";
            this.rdFacil.Size = new System.Drawing.Size(70, 29);
            this.rdFacil.TabIndex = 18;
            this.rdFacil.TabStop = true;
            this.rdFacil.Text = "Fácil";
            this.rdFacil.UseVisualStyleBackColor = true;
            // 
            // FormExibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 759);
            this.Controls.Add(this.panelDificuldade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.autorR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CorpoR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalvarR);
            this.Controls.Add(this.ingredientesR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeR);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormExibir";
            this.Text = "FormExibir";
            this.Load += new System.EventHandler(this.FormExibir_Load_1);
            this.panelDificuldade.ResumeLayout(false);
            this.panelDificuldade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ingredientesR;
        private Label label2;
        private TextBox NomeR;
        private Label label1;
        private Button SalvarR;
        private TextBox CorpoR;
        private Label label3;
        private TextBox autorR;
        private Label label4;
        private Label label5;
        private Panel panelDificuldade;
        private RadioButton rdDificil;
        private RadioButton rdMedia;
        private RadioButton rdFacil;
    }
}