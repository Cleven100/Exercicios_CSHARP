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
    public partial class Form2 : Form
    {
        Thread t2;

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Id, Senha;

            Id = textBox3.Text;
            Senha = textBox4.Text;

            if (Id == "Cleven")
            {

                if (Senha == "157455")
                {

                    this.Close();
                    t2 = new Thread(abrirJanela);
                    t2.SetApartmentState(ApartmentState.STA);
                    t2.Start();

                }
                else if (Senha != "157455")
                {

                    MessageBox.Show("Senha Errada");

                }


            }
            else if (Id != "Cleven")
            {
                MessageBox.Show("ID INCORRETO");
            }








        }
        private void abrirJanela(object obj)
        {
            Application.Run(new Form3());
        }
    }
}
