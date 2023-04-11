using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace LivroReceitasDigital
{
    public partial class FormPrincipal : Form
    {
        private List<Receita> ListaReceitas;
        private bool houveModificacao = false;

        // Cria/carrega ListaReceitas.
        public FormPrincipal()
        {
            InitializeComponent();

            if(File.Exists(Directory.GetCurrentDirectory() + "/dados.json"))
            {
                AtualizarListaReceitas();
            } else
            {
                ListaReceitas = new List<Receita>();
            }

            ExibirListaReceitas();
        }

        // Atualiza lista de receitas na RAM.
        private void AtualizarListaReceitas()
        {
            ListaReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receita>>(File.ReadAllText(Directory.GetCurrentDirectory() + "/dados.json"));
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }


        //Deleta um objeto Receita de ListaReceitas e sobre-escreve o arquivo
        //private void ExcluirReceita(Receita receita)
        //{
        //    ListaReceitas.Remove(receita);
        //    SobrescreverArquivo();
        //}

        //Sobre-escreve o arquivo JSON com ListaReceitas em seu estado atual
        private void SobrescreverArquivo()
        {
            string receitaJson = Newtonsoft.Json.JsonConvert.SerializeObject(ListaReceitas);
            File.WriteAllText(Directory.GetCurrentDirectory() + "/dados.json", receitaJson);
        }

        //Cria objeto Receita, envia ao FormExibir, adiciona a ListaReceitas, ordena, sobreescreve arquivo.
        private void btnCriar_Click(object sender, EventArgs e)
        {         
            Receita receita = new Receita();
            FormExibir frm = new FormExibir(receita);
            var dialogResult = frm.ShowDialog();

            if (dialogResult.ToString().Equals("Yes"))
            {
                ListaReceitas.Add(receita);
                
                Ordenar(); 
                SobrescreverArquivo();
                AtualizarListaReceitas();
                ExibirListaReceitas();
            }
        }

        //Carrega o datagridview com a lista de receitas.
        private void ExibirListaReceitas()
        {
            dgvListaReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaReceitas.DataSource = ListaReceitas;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        //Envia um item objeto Receita ao FormExibir
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListaReceitas.SelectedRows[0];
            String nomeReceita = row.Cells[0].Value.ToString();
            
            Receita receita = ListaReceitas.Where(i => i.Nome.Equals(nomeReceita)).First();

            String corpoReceita = receita.Corpo.ToString();
            FormExibir frm = new FormExibir(receita);
            var dialogResult = frm.ShowDialog();

            if (dialogResult.ToString().Equals("Yes"))
            {
                Ordenar();
                SobrescreverArquivo();
                AtualizarListaReceitas();
                ExibirListaReceitas();
            }
        }

        private void Ordenar()
        {
            ListaReceitas = ListaReceitas.OrderBy(p => p.Nome).ToList();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            textPesquisaTitulo.Text = string.Empty;
            textPesquisaIngrediente.Text = string.Empty;
            rdPesquisaFacil.Checked = false;
            rdPesquisaMedia.Checked = false;
            rdPesquisaDificil.Checked = false;
            AtualizarListaReceitas();
            ExibirListaReceitas();
        }

        private void btnPesquisarDificuldade_Click(object sender, EventArgs e)
        {
            String dificuldade = "";

            if (rdPesquisaFacil.Checked)
            {
               dificuldade = "Fácil";
            }
            else if (rdPesquisaMedia.Checked)
            {
                dificuldade = "Média";
            }
            else if (rdPesquisaDificil.Checked)
            {
                dificuldade = "Difícil";
            }

            dgvListaReceitas.DataSource = ListaReceitas.Where(i => i.Dificuldade.Equals(dificuldade)).ToList();
        }

        private void btnExcluirClick(object sender, EventArgs e)
        {
            if (dgvListaReceitas.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dgvListaReceitas.SelectedRows[0];
                String nomeReceita = row.Cells[0].Value.ToString();
                Receita receita = ListaReceitas.Where(i => i.Nome.Equals(nomeReceita)).First();
                ListaReceitas.Remove(receita);

                Ordenar();
                SobrescreverArquivo();
                AtualizarListaReceitas();
                ExibirListaReceitas();
            }
        }

        private void btnPesquisarTitulo_Click(object sender, EventArgs e)
        {
            String pesquisa = textPesquisaTitulo.Text;
            dgvListaReceitas.DataSource = ListaReceitas.Where(i => i.Nome.Contains(pesquisa)).ToList();
        }

        private void btnPesquisaIngrediente_Click(object sender, EventArgs e)
        {
            String pesquisa = textPesquisaIngrediente.Text;
            dgvListaReceitas.DataSource = ListaReceitas.Where(i => i.Ingredientes.Contains(pesquisa)).ToList();
        }
    }
}