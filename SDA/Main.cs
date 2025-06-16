using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;

namespace SDA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
         // Close App
        private void btn_close_Click(object sender, EventArgs e)
        {
            
            Close(); // Environment.Exit(0); 


        }
        // MaxMixe App

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        } 
        // Minimie App

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Nitifiction App
        private void btn_not_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(
                "Hello My Team");
        }

        private void pn_cont_Paint(object sender, PaintEventArgs e)
        {

        }
        // Collapes
        private void btn_collapes_Click(object sender, EventArgs e)
        {
            if(pn_navbar.Width == 239)
            {
                pn_navbar.Width = 50;
                pn_titalnav.Visible = false;
                pn_headernavbar.Height = 200;
            }
            else
            {
                pn_navbar.Width = 239;
                pn_titalnav.Visible = true;
                pn_headernavbar.Height = 215;

            }
        }
    }
}
