namespace Coisa_Boa
{
    partial class Criar_Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxFabricante = new TextBox();
            textBoxNome = new TextBox();
            InputPrecoCompra = new NumericUpDown();
            Ok = new Button();
            Cancel = new Button();
            InputPrecoVenda = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)InputPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 111);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 80);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Fabricante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 166);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 2;
            label4.Text = "Preço de venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 126);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 2;
            label5.Text = "Preco de Compra";
            label5.Click += label5_Click;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(176, 80);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(100, 23);
            textBoxFabricante.TabIndex = 3;
            textBoxFabricante.TextChanged += textBox1_TextChanged;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(176, 38);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 3;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // InputPrecoCompra
            // 
            InputPrecoCompra.DecimalPlaces = 2;
            InputPrecoCompra.Location = new Point(176, 124);
            InputPrecoCompra.Name = "InputPrecoCompra";
            InputPrecoCompra.Size = new Size(120, 23);
            InputPrecoCompra.TabIndex = 4;
            InputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            InputPrecoCompra.ValueChanged += InputPrecoCompra_ValueChanged;
            // 
            // Ok
            // 
            Ok.Location = new Point(123, 219);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 21);
            Ok.TabIndex = 5;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(261, 219);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 6;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // InputPrecoVenda
            // 
            InputPrecoVenda.DecimalPlaces = 2;
            InputPrecoVenda.Location = new Point(175, 166);
            InputPrecoVenda.Name = "InputPrecoVenda";
            InputPrecoVenda.Size = new Size(120, 23);
            InputPrecoVenda.TabIndex = 7;
            InputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            InputPrecoVenda.ValueChanged += InputPrecoVenda_ValueChanged;
            // 
            // Criar_Produto
            // 
            AcceptButton = Ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Cancel;
            ClientSize = new Size(800, 450);
            Controls.Add(InputPrecoVenda);
            Controls.Add(Cancel);
            Controls.Add(Ok);
            Controls.Add(InputPrecoCompra);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxFabricante);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Criar_Produto";
            Text = "Criar_Produto";
            Load += Criar_Produto_Load;
            ((System.ComponentModel.ISupportInitialize)InputPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxFabricante;
        private TextBox textBoxNome;
        private NumericUpDown InputPrecoCompra;
        private Button Ok;
        private Button Cancel;
        private NumericUpDown InputPrecoVenda;
    }
}