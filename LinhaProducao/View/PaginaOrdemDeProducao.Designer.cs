namespace LinhaProducao.View
{
    partial class PaginaOrdemDeProducao
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
            this.listViewOrdemDeProducao = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewOrdemDeProducao
            // 
            this.listViewOrdemDeProducao.HideSelection = false;
            this.listViewOrdemDeProducao.Location = new System.Drawing.Point(12, 12);
            this.listViewOrdemDeProducao.Name = "listViewOrdemDeProducao";
            this.listViewOrdemDeProducao.Size = new System.Drawing.Size(776, 426);
            this.listViewOrdemDeProducao.TabIndex = 0;
            this.listViewOrdemDeProducao.UseCompatibleStateImageBehavior = false;
            this.listViewOrdemDeProducao.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // PaginaOrdemDeProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewOrdemDeProducao);
            this.Name = "PaginaOrdemDeProducao";
            this.Text = "PaginaOrdemDeProducao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrdemDeProducao;
    }
}