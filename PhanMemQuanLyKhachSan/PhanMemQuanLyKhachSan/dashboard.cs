using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddroom_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnAddroom.Left = +50;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            btnAddroom.PerformClick();
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }
    }
}
