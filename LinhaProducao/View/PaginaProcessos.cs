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
using MySqlX.XDevAPI;

namespace LinhaProducao.View
{
    public partial class PaginaProcessos : Form
    {
        public PaginaProcessos()
        {
            InitializeComponent();

            try
            {
                Processos processos = new Processos();  

                listViewProcessos.Bounds = new Rectangle(new Point(10, 10), new Size(700, 490));
                listViewProcessos.View = System.Windows.Forms.View.Details;
                listViewProcessos.LabelEdit = true;
                listViewProcessos.AllowColumnReorder = true;
                listViewProcessos.CheckBoxes = true;
                listViewProcessos.FullRowSelect = true;
                listViewProcessos.GridLines = true;
                listViewProcessos.Sorting = SortOrder.Ascending;

                listViewProcessos.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewProcessos.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewProcessos.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewProcessos.Columns.Add("ID_SETOR", -2, HorizontalAlignment.Left);

                foreach (Processos processo in processos.GetListaProcessos())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(processo.id.ToString());
                    item.SubItems.Add(processo.nome);
                    item.SubItems.Add(processo.id_setor.ToString());
                    listViewProcessos.Items.Add(item);
                }
            }
            catch (Exception excpetion)
            {
                MessageBox.Show(excpetion.Message);
            }
        }

        private void listViewProcessos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
