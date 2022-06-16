using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaTro
{
    public partial class MIDForm : Form
    {
        public MIDForm()
        {
            InitializeComponent();
        }

        private void mnu1ChuNha_Click(object sender, EventArgs e)
        {
            frmQLChuNha frm = new frmQLChuNha();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnu1DichVu_Click(object sender, EventArgs e)
        {
            frmDichVu frm = new frmDichVu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnu1TinhTrangPhong_Click(object sender, EventArgs e)
        {
            frmLoaiPhong frm = new frmLoaiPhong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnu2KhachThue_Click(object sender, EventArgs e)
        {
            frmKhachThue frm = new frmKhachThue();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTinhTrangHoaDon_Click(object sender, EventArgs e)
        {
            frmThanhToanHoaDon frm = new frmThanhToanHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnu1PhongTro_Click(object sender, EventArgs e)
        {
            frmPhongTro frm = new frmPhongTro();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
