using LinhaDeProducao;
using Listas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Etapas etapa = new Etapas();


                etapa.nome = "PEPE";
                etapa.ordem = 3;
                etapa.id_processo = 9;



                etapa.Insert();
                

                MessageBox.Show("Cliente adicionado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


    }
}

