namespace LinhaProducao.View
{
    partial class PaginaClientes
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
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewClientes
            // 
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(2, 2);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(786, 436);
            this.listViewClientes.TabIndex = 0;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            this.listViewClientes.SelectedIndexChanged += new System.EventHandler(this.listViewClientes_SelectedIndexChanged);
            // 
            // PaginaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewClientes);
            this.Name = "PaginaClientes";
            this.Text = "PaginaClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClientes;
    }
}