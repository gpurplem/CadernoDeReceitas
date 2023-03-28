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

        private void AbrirReceita(Receita receita)
        {
            //envia obj Receita e abre FormExibir preenchido com ele
        } 

        private void CriarReceita()
        {
            //a.cria um obj Receita na lista(vazio)
            //b.envia esse obj pro FormExibir
            //c.abre FormExibir pra editar
        }

        private void ExcluirReceita(Receita receita)
        {
            //a.Deleta a receita da lista, sobrescrever o arquivo
        }

        private void SobrescreverArquivo()
        {
            //a.pega a lista, transforma em JSON, salva
        }

        private List<Receita> GetReceitas(FileStream arquivo)
        {
            //abre o arquivo json > cria uma lista de objetos Receitas com base no arquivo
            return new List<Receita>();
        }

    }
}