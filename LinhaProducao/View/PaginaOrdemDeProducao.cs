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
    public partial class PaginaOrdemDeProducao : Form
    {
        public PaginaOrdemDeProducao()
        {
            InitializeComponent();

            try
            {
                OrdemProducaos ordemProducaos = new OrdemProducaos();

                listViewOrdemDeProducao.Bounds = new Rectangle(new Point(10, 10), new Size(700, 490));
                listViewOrdemDeProducao.View = System.Windows.Forms.View.Details;
                listViewOrdemDeProducao.LabelEdit = true;
                listViewOrdemDeProducao.AllowColumnReorder = true;
                listViewOrdemDeProducao.CheckBoxes = true;
                listViewOrdemDeProducao.FullRowSelect = true;
                listViewOrdemDeProducao.GridLines = true;
                listViewOrdemDeProducao.Sorting = SortOrder.Ascending;

                listViewOrdemDeProducao.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewOrdemDeProducao.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewOrdemDeProducao.Columns.Add("ID_EMPRESA", -2, HorizontalAlignment.Left);
                listViewOrdemDeProducao.Columns.Add("ID_SETOR", -2, HorizontalAlignment.Left);
                listViewOrdemDeProducao.Columns.Add("ID_CLIENTE", -2, HorizontalAlignment.Left);

                foreach (OrdemProducaos ordemProducao in ordemProducaos.GetListaOrdemProducao())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(ordemProducao.id.ToString());
                    item.SubItems.Add(ordemProducao.id_empresa.ToString());
                    item.SubItems.Add(ordemProducao.id_setor.ToString());
                    item.SubItems.Add(ordemProducao.id_cliente.ToString());

                    listViewOrdemDeProducao.Items.Add(item);
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
