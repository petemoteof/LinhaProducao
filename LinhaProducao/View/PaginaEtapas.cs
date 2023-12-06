using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Listas;

namespace LinhaProducao.View
{
    public partial class PaginaEtapas : Form
    {
        public PaginaEtapas()
        {
            InitializeComponent();
            try
            {   
                Etapas etapa = new Etapas();

                listViewEtapas.Bounds = new Rectangle(new Point(10, 10), new Size(700, 490));
                listViewEtapas.View = System.Windows.Forms.View.Details;
                listViewEtapas.LabelEdit = true;
                listViewEtapas.AllowColumnReorder = true;
                listViewEtapas.CheckBoxes = true;
                listViewEtapas.FullRowSelect = true;
                listViewEtapas.GridLines = true;
                listViewEtapas.Sorting = SortOrder.Ascending;

                listViewEtapas.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("ORDEM", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("ID_PROCESSO", -2, HorizontalAlignment.Left);

                foreach (Etapas etapas in etapa.GetListaEtapas())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(etapas.id.ToString());
                    item.SubItems.Add(etapas.nome);
                    item.SubItems.Add(etapas.ordem.ToString());
                    item.SubItems.Add(etapas.id_processo.ToString());
                    listViewEtapas.Items.Add(item);
                }
            }
            catch (Exception excpetion)
            {
                MessageBox.Show(excpetion.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
