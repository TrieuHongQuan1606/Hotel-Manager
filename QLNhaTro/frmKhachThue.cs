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
    public partial class frmKhachThue : Form
    {
        DBNhaTroDataContext db = new DBNhaTroDataContext();
        DataGridViewCellMouseEventArgs vt;
        bool ktThem;
        string macu = "", sDK="";
        public frmKhachThue()
        {
            InitializeComponent();
        }

        private void frmKhachThue_Load(object sender, EventArgs e)
        {
            KhoaMo(true);
            LayNguon();
        }
        public void LayNguon()
        {
            var dl = db.KHACHTHUEs.OrderBy(p => p.HoTen).ToList();
            if (sDK != "")
                dl = db.KHACHTHUEs.Where(p => p.CCCD.Contains(sDK) || p.HoTen.Contains(sDK) || p.SDT.Contains(sDK)).OrderBy(p => p.HoTen).ToList();

            dgDanhSach.DataSource = dl;
        }

        public void XoaTrang()
        {
            txtCCCD.Text = ""; txtHoTen.Text = ""; txtSDT.Text = ""; txtQueQuan.Text = "";
            txtDiaChi.Text = "";txtThongTin.Text = "";txtGhiChu.Text = "";
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter)
            {
                sDK = txtTimKiem.Text;
                LayNguon();
            }
        }

        private void dgDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhSach.Rows[e.RowIndex];
                txtCCCD.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtQueQuan.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtThongTin.Text = row.Cells[5].Value.ToString();
                txtGhiChu.Text = row.Cells[6].Value.ToString();
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KhoaMo(false);
            txtHoTen.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "") return;
            ktThem = false;
            KhoaMo(false);
            macu = txtCCCD.Text;
            txtHoTen.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "") return;
            if (MessageBox.Show("Bạn có muốn xóa [ " + txtHoTen.Text + " ] không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                macu = txtCCCD.Text;
                KHACHTHUE obj = db.KHACHTHUEs.Where(p => p.CCCD.Equals(macu)).SingleOrDefault();
                db.KHACHTHUEs.DeleteOnSubmit(obj);
                db.SubmitChanges();
                XoaTrang(); 
                LayNguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số CCCD/số CMND.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCCCD.Focus();
                return;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (ktTrungMa() == true)
            {
                MessageBox.Show("Bạn nhập trùng số CCCD/ số CMND của người khác.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCCCD.Focus();
                return;
            }

            if (ktThem == true)
            {
                KHACHTHUE obj = new KHACHTHUE();
                obj.HoTen = txtHoTen.Text; obj.CCCD = txtCCCD.Text; obj.SDT = txtSDT.Text;
                obj.QueQuan = txtQueQuan.Text; obj.DiaChi = txtDiaChi.Text; obj.ThongTinKhac = txtThongTin.Text; obj.GhiChu = txtGhiChu.Text;
                db.KHACHTHUEs.InsertOnSubmit(obj);
            }
            else
            {
                KHACHTHUE objU = db.KHACHTHUEs.Where(p => p.CCCD.Equals(macu)).SingleOrDefault();
                objU.HoTen = txtHoTen.Text; objU.CCCD = txtCCCD.Text; objU.SDT = txtSDT.Text;
                objU.QueQuan = txtQueQuan.Text; objU.DiaChi = txtDiaChi.Text; objU.ThongTinKhac = txtThongTin.Text; objU.GhiChu = txtGhiChu.Text;
            }
            db.SubmitChanges();
            KhoaMo(true);
            LayNguon();
            try
            {
                XoaTrang();
                dgDanhSach_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        public bool ktTrungMa()
        {
            var kt = db.KHACHTHUEs.Where(p => p.CCCD.Equals(txtCCCD.Text)).ToList();
            if (kt.Count > 0)
            {
                if (ktThem == true)
                    return true;
                else
                   if (kt[0].CCCD.Equals(macu) == false)
                    return true;
            }
            return false;
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            try
            {
                XoaTrang();
                KhoaMo(true);
                dgDanhSach_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        public void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b; cmdXoa.Enabled = b; cmdKetThuc.Enabled = b;

            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;

            txtCCCD.ReadOnly = b; txtHoTen.ReadOnly = b; txtSDT.ReadOnly = b; txtQueQuan.ReadOnly = b;
            txtDiaChi.ReadOnly = b; txtThongTin.ReadOnly = b; txtGhiChu.ReadOnly = b;

            txtTimKiem.ReadOnly = !b;
        }
    }
}
