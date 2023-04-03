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
    public partial class FormExibir : Form
    {
        public FormExibir(Receita receita)
        {
            InitializeComponent();
        }

        private void FormExibir_Load(object sender, EventArgs e, Receita ItemReceita)
        {
            NomeR.Text = ItemReceita.Nome;
            CorpoR.Text = ItemReceita.Corpo;

        }

        private void AtualizaR(Receita ItemReceita)
        {
            ItemReceita.Nome = NomeR.Text;
            ItemReceita.Corpo = CorpoR.Text;
        }

        private void SalvarR_Click(object sender, EventArgs e, Receita ItemReceita)
        {
            AtualizaR(ItemReceita);
        }
    }
}
