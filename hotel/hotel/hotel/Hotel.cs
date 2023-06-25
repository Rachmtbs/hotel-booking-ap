using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void occupancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OccupanciesChild o = new OccupanciesChild();
            o.MdiParent = this;
            o.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientChild c = new ClientChild();
            c.MdiParent = this;
            c.Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomsChild r = new RoomsChild();
            r.MdiParent = this;
            r.Show();
        }

        private void customerSideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerChild h = new CustomerChild();
            h.MdiParent = this;
            h.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
