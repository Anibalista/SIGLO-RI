﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RingoFront
{
    public partial class FrmRegistrarPrenda : Form
    {
        public FrmRegistrarPrenda()
        {
            InitializeComponent();
        }

        private void btnCancelarPrenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
