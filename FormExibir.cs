using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivroReceitasDigital
{
    public partial class FormExibir : Form, IDisposable
    {
        Receita receita;

        //Chama as funções e executa no form
        public FormExibir(Receita receita)
        {
            InitializeComponent();
            this.receita = receita;
            ExibirReceita();
        }

        private void FormExibir_Load(object sender, EventArgs e)
        {
            
        }

        //Exibe a receita 
        private void ExibirReceita()
        {
            NomeR.Text = receita.Nome;
            CorpoR.Text = receita.Corpo; //Modo preparo
            ingredientesR.Text = receita.Ingredientes;
            autorR.Text = receita.Autor;
            String dificuldadeStr = receita.Dificuldade;

            if(dificuldadeStr != null)
            {
                if (dificuldadeStr.Equals("Fácil"))
                {
                    rdFacil.Select();
                }
                else if (dificuldadeStr.Equals("Média"))
                {
                    rdMedia.Select();
                }
                else if (dificuldadeStr.Equals("Difícil"))
                {
                    rdDificil.Select();
                }
            }           
        }

        private void AtualizaR()
        {
            receita.Nome = NomeR.Text;
            receita.Corpo = CorpoR.Text; //Modo preparo
            receita.Ingredientes = ingredientesR.Text;
            receita.Autor = autorR.Text;

            if (rdFacil.Checked)
            {
                receita.Dificuldade = "Fácil";
            }
            else if (rdMedia.Checked)
            {
                receita.Dificuldade = "Média";
            }
            else if (rdDificil.Checked)
            {
                receita.Dificuldade = "Difícil";
            }
        }

        private void SalvarR_Click(object sender, EventArgs e)
        {
            AtualizaR();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormExibir_Load_1(object sender, EventArgs e)
        {

        }
    }
}
