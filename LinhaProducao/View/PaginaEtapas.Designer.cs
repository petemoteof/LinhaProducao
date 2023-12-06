namespace LinhaProducao.View
{
    partial class PaginaEtapas
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
            this.listViewEtapas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewEtapas
            // 
            this.listViewEtapas.HideSelection = false;
            this.listViewEtapas.Location = new System.Drawing.Point(12, 12);
            this.listViewEtapas.Name = "listViewEtapas";
            this.listViewEtapas.Size = new System.Drawing.Size(776, 426);
            this.listViewEtapas.TabIndex = 0;
            this.listViewEtapas.UseCompatibleStateImageBehavior = false;
            this.listViewEtapas.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // PaginaEtapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewEtapas);
            this.Name = "PaginaEtapas";
            this.Text = "PaginaEtapas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEtapas;
    }
}