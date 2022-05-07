﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManageBook.GUI
{
    public partial class Dashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Dashboard()
        {
            InitializeComponent();
            ManageBook frm = new ManageBook();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("test");
            ManageBook frm = new ManageBook();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            this.pContainerP.Controls.Add(frm);
            frm.Show();
        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(62, 91, 135);
        }
    }
}
