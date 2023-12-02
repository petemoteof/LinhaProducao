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
            this.barraLateral = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
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
            this.painelCaberalho.Size = new System.Drawing.Size(780, 56);
            this.painelCaberalho.TabIndex = 0;
            // 
            // barraLateral
            // 
            this.barraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.barraLateral.Controls.Add(this.buttonCliente);
            this.barraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraLateral.Location = new System.Drawing.Point(0, 56);
            this.barraLateral.Name = "barraLateral";
            this.barraLateral.Size = new System.Drawing.Size(137, 401);
            this.barraLateral.TabIndex = 1;
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
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCliente.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.ForeColor = System.Drawing.Color.White;
            this.buttonCliente.Location = new System.Drawing.Point(10, 6);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(117, 45);
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
            this.panelConteudo.Size = new System.Drawing.Size(643, 401);
            this.panelConteudo.TabIndex = 2;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 457);
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
    }
}