namespace LinhaProducao.View
{
    partial class PaginaSetor
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
            this.listViewSetor = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewSetor
            // 
            this.listViewSetor.HideSelection = false;
            this.listViewSetor.Location = new System.Drawing.Point(12, 12);
            this.listViewSetor.Name = "listViewSetor";
            this.listViewSetor.Size = new System.Drawing.Size(776, 426);
            this.listViewSetor.TabIndex = 0;
            this.listViewSetor.UseCompatibleStateImageBehavior = false;
            this.listViewSetor.SelectedIndexChanged += new System.EventHandler(this.listViewSetor_SelectedIndexChanged);
            // 
            // PaginaSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewSetor);
            this.Name = "PaginaSetor";
            this.Text = "PaginaSetor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSetor;
    }
}