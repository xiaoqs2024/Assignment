﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class ChangeOrderInterface : Form
    {
        public string orderIDvalue;
        public ChangeOrderInterface()
        {
            InitializeComponent();
        }

        private void ChangeOrderInterface_Load(object sender, EventArgs e)
        {

        }
        //取消
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
