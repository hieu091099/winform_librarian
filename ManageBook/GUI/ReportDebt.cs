using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ManageBook.BUS;

namespace ManageBook.GUI
{
    public partial class ReportDebt : DevExpress.XtraEditors.XtraForm
    {
        public ReportDebt()
        {
            InitializeComponent();
        }
        CustomerBUS b = new CustomerBUS();

        private void ReportDebt_Load(object sender, EventArgs e)
        {
            try
            {
                // window
                reportViewer1.LocalReport.ReportEmbeddedResource = "ManageBook.Report1.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = b.reportDebt();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
