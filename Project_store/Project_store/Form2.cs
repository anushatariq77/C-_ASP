﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_store
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StoreView' table. You can move, or remove it, as needed.
            //his.storeViewTableAdapter.Fill(this.dataSet1.StoreView);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.storeViewTableAdapter.FillByStoreName(this.dataSet1.StoreView, "%" + textBox1.Text + "%");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
