namespace LinhaProducao.View
{
    partial class PaginaPrincipal
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
            this.painelCaberalho = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.barraLateral = new System.Windows.Forms.Panel();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.buttonLinhaProducao = new System.Windows.Forms.Button();
            this.buttonOrdemProducao = new System.Windows.Forms.Button();
            this.buttonSetor = new System.Windows.Forms.Button();
            this.buttonProcessos = new System.Windows.Forms.Button();
            this.buttonEtapas = new System.Windows.Forms.Button();
            this.painelCaberalho.SuspendLayout();
            this.barraLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCaberalho
            // 
            this.painelCaberalho.BackColor = System.Drawing.Color.Goldenrod;
            this.painelCaberalho.Controls.Add(this.labelTitulo);
            this.painelCaberalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelCaberalho.Location = new System.Drawing.Point(0, 0);
            this.painelCaberalho.Name = "painelCaberalho";
            this.painelCaberalho.Size = new System.Drawing.Size(1297, 56);
            this.painelCaberalho.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Goldenrod;
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTitulo.Location = new System.Drawing.Point(3, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(289, 42);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Linha de Produção";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // barraLateral
            // 
            this.barraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.barraLateral.Controls.Add(this.buttonProdutos);
            this.barraLateral.Controls.Add(this.buttonEtapas);
            this.barraLateral.Controls.Add(this.buttonProcessos);
            this.barraLateral.Controls.Add(this.buttonSetor);
            this.barraLateral.Controls.Add(this.buttonOrdemProducao);
            this.barraLateral.Controls.Add(this.buttonLinhaProducao);
            this.barraLateral.Controls.Add(this.buttonCliente);
            this.barraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraLateral.Location = new System.Drawing.Point(0, 56);
            this.barraLateral.Name = "barraLateral";
            this.barraLateral.Size = new System.Drawing.Size(137, 580);
            this.barraLateral.TabIndex = 1;
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdutos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProdutos.ForeColor = System.Drawing.Color.White;
            this.buttonProdutos.Location = new System.Drawing.Point(10, 288);
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.Size = new System.Drawing.Size(117, 40);
            this.buttonProdutos.TabIndex = 2;
            this.buttonProdutos.Text = "Produtos";
            this.buttonProdutos.UseVisualStyleBackColor = false;
            this.buttonProdutos.Click += new System.EventHandler(this.buttonProdutos_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.ForeColor = System.Drawing.Color.White;
            this.buttonCliente.Location = new System.Drawing.Point(10, 3);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(117, 43);
            this.buttonCliente.TabIndex = 1;
            this.buttonCliente.Text = "Clientes";
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(137, 56);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(1160, 580);
            this.panelConteudo.TabIndex = 2;
            this.panelConteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConteudo_Paint);
            // 
            // buttonLinhaProducao
            // 
            this.buttonLinhaProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonLinhaProducao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonLinhaProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLinhaProducao.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLinhaProducao.ForeColor = System.Drawing.Color.White;
            this.buttonLinhaProducao.Location = new System.Drawing.Point(10, 108);
            this.buttonLinhaProducao.Name = "buttonLinhaProducao";
            this.buttonLinhaProducao.Size = new System.Drawing.Size(117, 70);
            this.buttonLinhaProducao.TabIndex = 3;
            this.buttonLinhaProducao.Text = "Linha de Produção";
            this.buttonLinhaProducao.UseVisualStyleBackColor = false;
            this.buttonLinhaProducao.Click += new System.EventHandler(this.buttonLinhaProducao_Click);
            // 
            // buttonOrdemProducao
            // 
            this.buttonOrdemProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonOrdemProducao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonOrdemProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdemProducao.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrdemProducao.ForeColor = System.Drawing.Color.White;
            this.buttonOrdemProducao.Location = new System.Drawing.Point(10, 184);
            this.buttonOrdemProducao.Name = "buttonOrdemProducao";
            this.buttonOrdemProducao.Size = new System.Drawing.Size(117, 98);
            this.buttonOrdemProducao.TabIndex = 4;
            this.buttonOrdemProducao.Text = "Ordem de Produção";
            this.buttonOrdemProducao.UseVisualStyleBackColor = false;
            this.buttonOrdemProducao.Click += new System.EventHandler(this.buttonOrdemProducao_Click);
            // 
            // buttonSetor
            // 
            this.buttonSetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonSetor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetor.ForeColor = System.Drawing.Color.White;
            this.buttonSetor.Location = new System.Drawing.Point(10, 390);
            this.buttonSetor.Name = "buttonSetor";
            this.buttonSetor.Size = new System.Drawing.Size(117, 44);
            this.buttonSetor.TabIndex = 5;
            this.buttonSetor.Text = "Setores";
            this.buttonSetor.UseVisualStyleBackColor = false;
            this.buttonSetor.Click += new System.EventHandler(this.buttonSetor_Click);
            // 
            // buttonProcessos
            // 
            this.buttonProcessos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonProcessos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonProcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcessos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcessos.ForeColor = System.Drawing.Color.White;
            this.buttonProcessos.Location = new System.Drawing.Point(10, 334);
            this.buttonProcessos.Name = "buttonProcessos";
            this.buttonProcessos.Size = new System.Drawing.Size(121, 50);
            this.buttonProcessos.TabIndex = 6;
            this.buttonProcessos.Text = "Processos";
            this.buttonProcessos.UseVisualStyleBackColor = false;
            this.buttonProcessos.Click += new System.EventHandler(this.buttonProcessos_Click);
            // 
            // buttonEtapas
            // 
            this.buttonEtapas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonEtapas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonEtapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEtapas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEtapas.ForeColor = System.Drawing.Color.White;
            this.buttonEtapas.Location = new System.Drawing.Point(6, 52);
            this.buttonEtapas.Name = "buttonEtapas";
            this.buttonEtapas.Size = new System.Drawing.Size(121, 50);
            this.buttonEtapas.TabIndex = 7;
            this.buttonEtapas.Text = "Etapas";
            this.buttonEtapas.UseVisualStyleBackColor = false;
            this.buttonEtapas.Click += new System.EventHandler(this.buttonEtapas_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 636);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.barraLateral);
            this.Controls.Add(this.painelCaberalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PaginaPrincipal";
            this.Text = "PaginaPrincipal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.painelCaberalho.ResumeLayout(false);
            this.painelCaberalho.PerformLayout();
            this.barraLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelCaberalho;
        private System.Windows.Forms.Panel barraLateral;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button buttonProdutos;
        private System.Windows.Forms.Button buttonLinhaProducao;
        private System.Windows.Forms.Button buttonOrdemProducao;
        private System.Windows.Forms.Button buttonSetor;
        private System.Windows.Forms.Button buttonProcessos;
        private System.Windows.Forms.Button buttonEtapas;
    }
}