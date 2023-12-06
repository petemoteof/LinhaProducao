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
    public partial class PaginaLinhaProducao : Form
    {
        public PaginaLinhaProducao()
        {
            InitializeComponent();

            try
            {
                Linha_Producao linhaProducao = new Linha_Producao();

                listViewLinhaProducao.Bounds = new Rectangle(new Point(10, 10), new Size(700, 490));
                listViewLinhaProducao.View = System.Windows.Forms.View.Details;
                listViewLinhaProducao.LabelEdit = true;
                listViewLinhaProducao.AllowColumnReorder = true;
                listViewLinhaProducao.CheckBoxes = true;
                listViewLinhaProducao.FullRowSelect = true;
                listViewLinhaProducao.GridLines = true;
                listViewLinhaProducao.Sorting = SortOrder.Ascending;

                listViewLinhaProducao.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewLinhaProducao.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewLinhaProducao.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewLinhaProducao.Columns.Add("ID_EMPRESA", -2, HorizontalAlignment.Left);
                listViewLinhaProducao.Columns.Add("ID_SETOR", -2, HorizontalAlignment.Left);
                listViewLinhaProducao.Columns.Add("ID_RESPONSAVEL", -2, HorizontalAlignment.Left);

                foreach (Linha_Producao linhaProducaos in linhaProducao.GetListaLinhaProducao())
                {
                    ListViewItem item = new ListViewItem("", 0);

                    item.Checked = true;
                    item.SubItems.Add(linhaProducaos.id.ToString());
                    item.SubItems.Add(linhaProducaos.nome);
                    item.SubItems.Add(linhaProducaos.id_empresa.ToString());
                    item.SubItems.Add(linhaProducaos.id_setor.ToString());
                    item.SubItems.Add(linhaProducaos.id_responsavel.ToString());
                    listViewLinhaProducao.Items.Add(item);
                }
            }
            catch (Exception excpetion)
            {
                MessageBox.Show(excpetion.Message);
            }
        }

        private void listViewLinhaProducao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
