using DevExpress.XtraEditors;
using ManageBook.GUI.FormFunction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageBook.GUI
{
    public partial class ManageSheet : DevExpress.XtraEditors.XtraUserControl
    {
        public ManageSheet()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewOrderBook formEdit = new NewOrderBook();
            formEdit.StartPosition = FormStartPosition.CenterScreen;
            formEdit.ShowDialog();
        }
    }
}
