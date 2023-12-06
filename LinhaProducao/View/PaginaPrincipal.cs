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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirForm<Forms>() where Forms : Form, new() 
        {
            Form formulario;
            panelConteudo.Controls.Clear();

            formulario = panelConteudo.Controls.OfType<Form>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;

                formulario.Dock = DockStyle.Fill;

                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

                formulario.BringToFront();

            }

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaClientes>();
        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaProdutos>();
        }

        private void buttonLinhaProducao_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaLinhaProducao>();
        }

        private void buttonOrdemProducao_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaOrdemDeProducao>();
        }

        private void buttonSetor_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaSetor>();
        }

        private void buttonProcessos_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaProcessos>();
        }

        private void buttonEtapas_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaEtapas>();
        }
    }
}
