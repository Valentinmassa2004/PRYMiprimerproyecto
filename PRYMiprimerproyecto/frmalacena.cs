﻿using System;
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
    public partial class frmalacena : Form
    {
        public frmalacena()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdbuscar_Click(object sender, EventArgs e)
        {
            frmstockproducto frmstockproducto = new frmstockproducto();
            frmstockproducto.ShowDialog();

        }
    }
}
