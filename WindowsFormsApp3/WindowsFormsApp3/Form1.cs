using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        ass11DataSet kk;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.menuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ass11DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cdDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cdDataSet.customer);
            // TODO: This line of code loads data into the 'ass11DataSet.customerdetail' table. You can move, or remove it, as needed.
            this.customerdetailTableAdapter.Fill(this.ass11DataSet.customerdetail);
            // TODO: This line of code loads data into the 'ass11DataSet.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.ass11DataSet.menu);
          

        }
    }
}
