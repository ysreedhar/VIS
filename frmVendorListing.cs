using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace VendorInformationSystem
{
    public partial class frmVendorListing : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public frmVendorListing()
        {
            InitializeComponent();
        }

        private void tblVendorInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();    
            this.tableAdapterManager.UpdateAll(this.dbVISDataSet);

        }

        private void frmVendorListing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVISDataSet.tblVendorInformation' table. You can move, or remove it, as needed.
            this.tblVendorInformationTableAdapter.Fill(this.dbVISDataSet.tblVendorInformation);

        }
    }
}