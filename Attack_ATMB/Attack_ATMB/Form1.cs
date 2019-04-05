using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attack_ATMB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dịchChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiChuyen dichuyenMDIChild = new DiChuyen();
            dichuyenMDIChild.MdiParent = this;
            dichuyenMDIChild.Show();
            dichuyenMDIChild.WindowState = FormWindowState.Minimized;
            dichuyenMDIChild.WindowState = FormWindowState.Maximized;
            dichuyenMDIChild.Dock = DockStyle.Fill;
        }

        private void hoánVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoanVi hoanviMDIChild = new HoanVi();
            hoanviMDIChild.MdiParent = this;
            hoanviMDIChild.Show();
            hoanviMDIChild.WindowState = FormWindowState.Minimized;
            hoanviMDIChild.WindowState = FormWindowState.Maximized;
            hoanviMDIChild.Dock = DockStyle.Fill;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About hoanviMDIChild = new About();
            hoanviMDIChild.MdiParent = this;
            hoanviMDIChild.Show();
            hoanviMDIChild.WindowState = FormWindowState.Minimized;
            hoanviMDIChild.WindowState = FormWindowState.Maximized;
            hoanviMDIChild.Dock = DockStyle.Fill;
        }

        private void huấnLuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuanLuyen hoanviMDIChild = new HuanLuyen();
            hoanviMDIChild.MdiParent = this;
            hoanviMDIChild.Show();
            hoanviMDIChild.WindowState = FormWindowState.Minimized;
            hoanviMDIChild.WindowState = FormWindowState.Maximized;
            hoanviMDIChild.Dock = DockStyle.Fill;
        }

        private void tấnCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TanCong hoanviMDIChild = new TanCong();
            hoanviMDIChild.MdiParent = this;
            hoanviMDIChild.Show();
            hoanviMDIChild.WindowState = FormWindowState.Minimized;
            hoanviMDIChild.WindowState = FormWindowState.Maximized;
            hoanviMDIChild.Dock = DockStyle.Fill;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
