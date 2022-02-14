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
    public partial class cadLocatario : Form
    {
        Thread t1;
        public cadLocatario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            t1 = new Thread(abrirMenuPrincipal);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form3());
        }

    }
}
