
namespace Coisa_Boa
{
    public partial class Criar_Produto : Form
    {
        public string nomeProduto { get { return this.textBoxNome.Text; } }
        public string nomeFabricante { get { return this.textBoxFabricante.Text; } }
        public decimal precoCompra { get { return (decimal)this.InputPrecoCompra.Value; } }
        public decimal precoVenda { get { return (decimal)this.InputPrecoVenda.Value; } }

        public Criar_Produto()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputPrecoCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InputPrecoVenda_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Criar_Produto_Load(object sender, EventArgs e)
        {

        }
    }
}