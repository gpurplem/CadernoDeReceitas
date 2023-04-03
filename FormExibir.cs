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
        public FormExibir(Receita receita)
        {
            InitializeComponent();
            this.receita = receita;
            ExibirReceita();
        }

        private void FormExibir_Load(object sender, EventArgs e)
        {
            
        }

        private void ExibirReceita()
        {
            NomeR.Text = receita.Nome;
            CorpoR.Text = receita.Corpo;
        }

        private void AtualizaR()
        {
            receita.Nome = NomeR.Text;
            receita.Corpo = CorpoR.Text;
        }

        //private void SalvarR_Click(object sender, EventArgs e, Receita ItemReceita)
        //{
        //    AtualizaR(ItemReceita);
        //}

        private void SalvarR_Click(object sender, EventArgs e)
        {
            AtualizaR();
        }
    }
}
