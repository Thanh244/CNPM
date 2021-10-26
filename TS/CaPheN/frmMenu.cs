using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaPheN
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnThemM_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLMatHang f2 = new QLMatHang();
            f2.ShowDialog();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn Thoát  ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCnNv_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLNhanVien f3 = new frmQLNhanVien();
            f3.ShowDialog();
        }

        private void frmMeNu_Load(object sender, EventArgs e)
        {

        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatMon f4 = new frmDatMon();
            f4.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
