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
    public partial class StoreDetailsForm : Form
    {
        public StoreDetailsForm()
        {
            InitializeComponent();
        }

        private void StoreDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.StoreView' table. You can move, or remove it, as needed.
            this.StoreViewTableAdapter.Fill(this.DataSet1.StoreView);

            this.reportViewer1.RefreshReport();
        }
    }
}
