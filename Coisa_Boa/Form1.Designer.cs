namespace Coisa_Boa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Adicionar = new Button();
            Remover = new Button();
            dataGridView_lista = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista).BeginInit();
            SuspendLayout();
            // 
            // Adicionar
            // 
            Adicionar.Cursor = Cursors.Hand;
            Adicionar.Location = new Point(80, 28);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(75, 23);
            Adicionar.TabIndex = 0;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // Remover
            // 
            Remover.Cursor = Cursors.Hand;
            Remover.ForeColor = SystemColors.ActiveCaptionText;
            Remover.Location = new Point(185, 28);
            Remover.Name = "Remover";
            Remover.Size = new Size(75, 23);
            Remover.TabIndex = 1;
            Remover.Text = "Remover";
            Remover.UseVisualStyleBackColor = true;
            Remover.Click += Remover_Click;
            // 
            // dataGridView_lista
            // 
            dataGridView_lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_lista.Location = new Point(12, 57);
            dataGridView_lista.Name = "dataGridView_lista";
            dataGridView_lista.Size = new Size(531, 364);
            dataGridView_lista.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_lista);
            Controls.Add(Remover);
            Controls.Add(Adicionar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Adicionar;
        private Button Remover;
        private DataGridView dataGridView_lista;
    }
}
