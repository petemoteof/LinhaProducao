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
    public partial class PaginaLogin : Form
    {
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void PaginaLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            string emmail = textBoxEmail.Text;
            string senha  = textBoxSenha.Text;

            try 
            {  
                Funcionario funcionario = new Funcionario();
                funcionario.email = emmail;
                funcionario.SetSenha(senha);

                funcionario.GetFuncionarioPorEmailESenha();

                if (funcionario.logado)
                {
                    this.Hide();


                    PaginaPrincipal paginaPrincipal = new PaginaPrincipal();

                    paginaPrincipal.Show();
                }
                else 
                {
                    throw new Exception("USUARIO OU SENHA ERRADO OTARIO");
                }

            }
            catch (Exception exception) 
            {
                MessageBox.Show(exception.Message);
            }
            MessageBox.Show("FUNCIONANDO OTARIO");
        }
    }
}
