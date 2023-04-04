using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace LivroReceitasDigital
{
    public partial class FormPrincipal : Form
    {
        private List<Receita> ListaReceitas;
        public bool HouveModificacao = false;

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

        private void AtualizarListaReceitas()
        {
            ListaReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receita>>(File.ReadAllText(Directory.GetCurrentDirectory() + "/dados.json"));
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }


        //Deleta um objeto Receita de ListaReceitas e sobre-escreve o arquivo
        private void ExcluirReceita(Receita receita)
        {
            ListaReceitas.Remove(receita);
            SobrescreverArquivo();
        }

        //Sobre-escreve o arquivo JSON com ListaReceitas em seu estado atual
        private void SobrescreverArquivo()
        {
            string receitaJson = Newtonsoft.Json.JsonConvert.SerializeObject(ListaReceitas);
            File.WriteAllText(Directory.GetCurrentDirectory() + "/dados.json", receitaJson);
        }

        //private List<Receita> GetReceitas(FileStream arquivo)
        //{
        //    //abre o arquivo json > cria uma lista de objetos Receitas com base no arquivo
        //    return new List<Receita>();
        //}


        //Cria objeto Receita, envia ao FormExibir, adiciona a ListaReceitas, ordena, sobreescreve arquivo.
        private void btnCriar_Click(object sender, EventArgs e)
        {         
            Receita receita = new Receita();
            FormExibir frm = new FormExibir(receita);
            frm.ShowDialog();
            
            if(receita.Nome.Length > 0)
            {
                ListaReceitas.Add(receita);
                //ordenar.
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
            if(dgvListaReceitas.SelectedRows.Count > 0){

                DataGridViewRow row = dgvListaReceitas.SelectedRows[0];
                string fileName = row.Cells[1].Value.ToString();
                dgvListaReceitas.Rows.RemoveAt(row.Index);
                File.Delete(fileName);
            }
        }

        //Envia um item objeto Receita ao FormExibir
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListaReceitas.SelectedRows[0];
            String nomeReceita = row.Cells[0].Value.ToString();
            Receita receita = ListaReceitas.Where(i => i.Nome.Equals(nomeReceita)).First();
            String corpoReceita = receita.Corpo.ToString();
            FormExibir frm = new FormExibir(receita);
            frm.ShowDialog();

            if (!receita.Corpo.Equals(corpoReceita) | !receita.Nome.Equals(nomeReceita))
            {
                SobrescreverArquivo();
                AtualizarListaReceitas();
                ExibirListaReceitas();
            }
        }
    }
}