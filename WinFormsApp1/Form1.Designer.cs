
namespace WinFormsApp1
{
    partial class MSDNDemo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exibicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AtualizarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Postagem,
            this.Exibicao,
            this.Resposta,
            this.Link});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(787, 401);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 300;
            // 
            // Postagem
            // 
            this.Postagem.HeaderText = "Postagem";
            this.Postagem.Name = "Postagem";
            this.Postagem.Width = 150;
            // 
            // Exibicao
            // 
            this.Exibicao.HeaderText = "Exibições";
            this.Exibicao.Name = "Exibicao";
            // 
            // Resposta
            // 
            this.Resposta.HeaderText = "Respostas";
            this.Resposta.Name = "Resposta";
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            // 
            // AtualizarButton
            // 
            this.AtualizarButton.Location = new System.Drawing.Point(12, 7);
            this.AtualizarButton.Name = "AtualizarButton";
            this.AtualizarButton.Size = new System.Drawing.Size(121, 32);
            this.AtualizarButton.TabIndex = 1;
            this.AtualizarButton.Text = "Atualizar Lista";
            this.AtualizarButton.UseVisualStyleBackColor = true;
            this.AtualizarButton.Click += new System.EventHandler(this.AtualizarButton_Click);
            // 
            // MSDNDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.AtualizarButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MSDNDemo";
            this.Text = "MSDNDemo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exibicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resposta;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.Button AtualizarButton;
    }
}

