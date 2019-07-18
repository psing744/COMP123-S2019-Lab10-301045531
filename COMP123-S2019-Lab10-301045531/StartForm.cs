﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301045531
{
    public partial class StartForm : Form
    {
        public MainForm mainform { get; set; }
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            mainform = new MainForm();
            SplashTimer.Enabled = false;
            mainform.Show();
            this.Hide();
        }
    }
}
