using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolZone
    {
    public partial class frmMain : Form
        {
        private int childForms = 0;
        public frmMain()
            {
            InitializeComponent();
            }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Close();
            }

        private void toolStripOpenList_Click(object sender, EventArgs e)
            {
            Form frmGridList = new Forms.frmGridList();
            frmGridList.MdiParent = this;
            frmGridList.Text = "List " + ++childForms;
            frmGridList.Show();
            }
        }
    }
