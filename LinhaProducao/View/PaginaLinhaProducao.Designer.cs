namespace LinhaProducao.View
{
    partial class PaginaLinhaProducao
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
            this.listViewLinhaProducao = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewLinhaProducao
            // 
            this.listViewLinhaProducao.HideSelection = false;
            this.listViewLinhaProducao.Location = new System.Drawing.Point(12, 12);
            this.listViewLinhaProducao.Name = "listViewLinhaProducao";
            this.listViewLinhaProducao.Size = new System.Drawing.Size(776, 426);
            this.listViewLinhaProducao.TabIndex = 0;
            this.listViewLinhaProducao.UseCompatibleStateImageBehavior = false;
            this.listViewLinhaProducao.SelectedIndexChanged += new System.EventHandler(this.listViewLinhaProducao_SelectedIndexChanged);
            // 
            // LinhaProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewLinhaProducao);
            this.Name = "LinhaProducao";
            this.Text = "LinhaProducao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLinhaProducao;
    }
}