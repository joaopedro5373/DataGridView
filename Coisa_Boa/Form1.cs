using System.ComponentModel;

namespace Coisa_Boa
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public Form1()       
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            this.dataGridView_lista.DataSource = produtos;
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            Criar_Produto cp = new Criar_Produto();
            var resultado = cp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();
                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(x => x.Id) + 1;
                
                produto.Nome = cp.nomeProduto;
                produto.Fabricante = cp.nomeFabricante;
                produto.PrecoVenda = cp.precoVenda;
                produto.PrecoCompra = cp.precoCompra;

                produtos.Add(produto);

            }
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            if (dataGridView_lista.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView_lista.SelectedRows[0].Index);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}