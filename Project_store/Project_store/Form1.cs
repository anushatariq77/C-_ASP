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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StoreView' table. You can move, or remove it, as needed.
            //this.storeViewTableAdapter.Fill(this.dataSet1.StoreView);
            // TODO: This line of code loads data into the 'dataSet1.center' table. You can move, or remove it, as needed.
            this.centerTableAdapter.Fill(this.dataSet1.center);
            // TODO: This line of code loads data into the 'dataSet1.maker' table. You can move, or remove it, as needed.
            this.makerTableAdapter.Fill(this.dataSet1.maker);
            // TODO: This line of code loads data into the 'dataSet1.make' table. You can move, or remove it, as needed.
            this.makeTableAdapter.Fill(this.dataSet1.make);
            // TODO: This line of code loads data into the 'dataSet1.store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.dataSet1.store);

            groupBox1.Visible = true;
            groupBox2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            storeBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            storeBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            storeBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            storeBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            storeBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            storeBindingSource.EndEdit();
            storeTableAdapter.Update(dataSet1.store);
            dataSet1.store.AcceptChanges();

            MessageBox.Show("Record Saved!");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            storeBindingSource.RemoveCurrent();

            storeBindingSource.EndEdit();
            storeTableAdapter.Update(dataSet1.store);
            dataSet1.store.AcceptChanges();

            MessageBox.Show("Record Deleted!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.storeViewTableAdapter.FillByStoreName(this.dataSet1.StoreView, "%" + textBox1.Text + "%");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.storeTableAdapter.FillByID(this.dataSet1.store, int.Parse( store_idLabel2.Text));

            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StoreDetailsForm store = new StoreDetailsForm();
            store.Show();
            this.Hide();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void name_of_scientistTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
