﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile_DEVILLA
{
    public partial class frmFileName : Form
    {
        public static string SetFileName;
        public frmFileName()
        {
            InitializeComponent();
        }

        private void frmFileName_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";
            Close();
        }
    }
}
