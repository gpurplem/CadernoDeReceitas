using System.ComponentModel;
using System.Security.Cryptography.Xml;

namespace LivroReceitasDigital
{
    public partial class FormPrincipal : Form
    {
        private BindingList<Receita> ListaReceitas;
        public bool HouveModificacao = false;

        //Cria/carrega ListaReceitas.
        public FormPrincipal()
        {
            InitializeComponent();

            if(File.Exists(Directory.GetCurrentDirectory() + "/dados.json"))
            {
                ListaReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<BindingList<Receita>>(File.ReadAllText(Directory.GetCurrentDirectory() + "/dados.json"));

            } else
            {
                ListaReceitas = new BindingList<Receita>();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        //Envia um item objeto Receita ao FormExibir
        private void AbrirReceita(Receita receita)
        {
            FormExibir frm = new FormExibir(receita);
            frm.Show();

            //O QUE FAZER NO FORMEXIBIR
            //public Form2(string qs)
            //{
            //    InitializeComponent();
            //    textBox1.Text = qs;

            //}
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
            }
        }

        private void ExibirListaReceitas()
        {

        }
    }
}