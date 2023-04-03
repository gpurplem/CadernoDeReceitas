using System.Security.Cryptography.Xml;

namespace LivroReceitasDigital
{
    public partial class FormPrincipal : Form
    {
        private List<Receita> ListaReceitas;
        public bool HouveModificacao = false;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        //Cria um objeto Receita vazio, envia esse objeto ao FormExibir
        private void CriarReceita()
        {
            //List<Receita> receita = new List<Receita>();
            Receita receita = null;
            FormExibir frm = new FormExibir(receita);
            frm.Show();
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
            File.WriteAllText(Directory.GetCurrentDirectory() + "dados.json", receitaJson);
        }

        private List<Receita> GetReceitas(FileStream arquivo)
        {
            //abre o arquivo json > cria uma lista de objetos Receitas com base no arquivo
            return new List<Receita>();
        }

    }
}