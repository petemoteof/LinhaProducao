using Listas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao.View
{
    public partial class PaginaClientes : Form
    {
        public PaginaClientes()

        {
            InitializeComponent();

            try
            {
                Cliente clientes = new Cliente();

                listViewClientes.Bounds = new Rectangle(new Point(10, 10), new Size(700, 490));
                listViewClientes.View = System.Windows.Forms.View.Details;
                listViewClientes.LabelEdit = true;
                listViewClientes.AllowColumnReorder = true;
                listViewClientes.CheckBoxes = true;
                listViewClientes.FullRowSelect = true;
                listViewClientes.GridLines = true;
                listViewClientes.Sorting = SortOrder.Ascending;

                listViewClientes.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("EMAIL", -2, HorizontalAlignment.Left);

                foreach (Cliente cliente in clientes.GetListaCliente())
                {
                    ListViewItem item = new ListViewItem("",0);

                    item.Checked = true;
                    item.SubItems.Add(cliente.id.ToString());
                    item.SubItems.Add(cliente.nome);
                    item.SubItems.Add(cliente.email);
                    listViewClientes.Items.Add(item);
                }
            }
            catch (Exception excpetion)
            {
                MessageBox.Show(excpetion.Message);
            }
        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaginaClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
