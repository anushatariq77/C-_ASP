using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.userView' table. You can move, or remove it, as needed.
            //this.userViewTableAdapter.Fill(this.dataSet3.userView);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.userViewTableAdapter.FillByLogin(this.dataSet3.userView, user_nameTextBox.Text , passwordTextBox.Text);
            int noofrec = 0;
            noofrec = dataSet3.userView.Rows.Count;

            if(noofrec>0)
            {
                if(typeTextBox.Text == "Store")
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }

                else if(typeTextBox.Text == "Center")
                {
                   

                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }

            }

            else
            {
                MessageBox.Show("Invalid User");

            }
        }
    }
}
