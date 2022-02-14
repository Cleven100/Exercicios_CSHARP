using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Crud_1
{
    public partial class Form3 : Form
    {
        Thread t3;
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(abrirProduto);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }


              private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(abrirCliente);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }


        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(abrirFuncionario);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();


        }
        private void locatárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(abrirLocatario);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }



        private void abrirProduto(object obj)
        {
            Application.Run(new cadProduto());
        }

        
        private void abrirCliente(object obj)
        {
            Application.Run(new cadCliente());
        }
        private void abrirFuncionario(object obj)
        {
            Application.Run(new cadFuncionario());
        }
        private void abrirLocatario(object obj)
        {
            Application.Run(new cadLocatario());
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
    }
}
