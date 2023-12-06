using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinhaDeProducao;
using Listas;

namespace LinhaProducao.View
{
    public partial class PaginaSetor : Form
    {
        public PaginaSetor()
        {
            InitializeComponent();

            try
            {
                Setor setor = new Setor();

                listViewSetor.Bounds = new Rectangle(new Point(10, 10), new Size(700, 490));
                listViewSetor.View = System.Windows.Forms.View.Details;
                listViewSetor.LabelEdit = true;
                listViewSetor.AllowColumnReorder = true;
                listViewSetor.CheckBoxes = true;
                listViewSetor.FullRowSelect = true;
                listViewSetor.GridLines = true;
                listViewSetor.Sorting = SortOrder.Ascending;

                listViewSetor.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewSetor.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewSetor.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewSetor.Columns.Add("ID_EMPRESA", -2, HorizontalAlignment.Left);
                listViewSetor.Columns.Add("ID_RESPONSAVEL", -2, HorizontalAlignment.Left);

                foreach (Setor setores in setor.GetListaSetor())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(setores.id.ToString());
                    item.SubItems.Add(setores.nome);
                    item.SubItems.Add(setores.id_empresa.ToString());
                    item.SubItems.Add(setores.id_responsavel.ToString());
                    listViewSetor.Items.Add(item);
                }
            }
            catch (Exception excpetion)
            {
                MessageBox.Show(excpetion.Message);
            }
        }

        private void listViewSetor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
