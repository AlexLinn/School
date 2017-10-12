using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolZone.Forms
    {
    public partial class frmGridList : Form
        {
        public frmGridList()
            {
            InitializeComponent();
            }
        private void OpenFilterForm(object sender, EventArgs e)
            {
            Form frmSearch = new Forms.frmSearch();
            frmSearch.Text = "Filter ";
            frmSearch.ShowDialog();
            }

        
        }
    }
