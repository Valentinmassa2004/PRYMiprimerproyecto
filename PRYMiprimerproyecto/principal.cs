using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRYMiprimerproyecto
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btnmensualidad_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void btnalacena_Click(object sender, EventArgs e)
        {
            frmalacena frmalacena = new frmalacena();         
            frmalacena.ShowDialog();    
        }
    }
}
