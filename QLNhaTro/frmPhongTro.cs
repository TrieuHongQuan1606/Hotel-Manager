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
    public partial class frmPhongTro : Form
    {
        DBNhaTroDataContext db = new DBNhaTroDataContext();
        DataGridViewCellMouseEventArgs vt;
        bool ktThem;
        string macu = "", sDK = "";

        public void XoaTrang()
        {
            txtMaPhong.Text = ""; txtGiaPhong.Text = "0"; txtThongTin.Text = ""; txtGhiChu.Text = "";
        }
        public void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b; cmdXoa.Enabled = b; cmdKetThuc.Enabled = b;

            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;

            txtMaPhong.ReadOnly = b; txtGiaPhong.ReadOnly = b; txtThongTin.ReadOnly = b; txtGhiChu.ReadOnly = b;
            cboTinhTrang.Enabled = !b;

            txtTimKiem.ReadOnly = !b;
        }
        public void LayNguon()
        {
            var dl = (from tt in db.TINHTRANGs join phong in db.PHONGTROs on tt.MaTinhTrang equals phong.MaTinhTrang
                      select new { phong.MaPhong, phong.GiaPhong, phong.ThongTin, phong.GhiChu, tt.MaTinhTrang, tt.TinhTrang1 }).ToList();
            if (sDK != "")
                dl = (from tt in db.TINHTRANGs
                      join phong in db.PHONGTROs on tt.MaTinhTrang equals phong.MaTinhTrang
                      where (phong.MaPhong.Contains(sDK) || (phong.GiaPhong == Double.Parse(sDK)) || phong.ThongTin.Contains(sDK))
                      select new { phong.MaPhong, phong.GiaPhong, phong.ThongTin, phong.GhiChu, tt.MaTinhTrang, tt.TinhTrang1 }).ToList();
            dgDanhSach.DataSource = dl;
        }
        public frmPhongTro()
        {
            InitializeComponent();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
                txtMaPhong.Text = row.Cells[0].Value.ToString();
                txtGiaPhong.Text = row.Cells[1].Value.ToString();
                txtThongTin.Text = row.Cells[2].Value.ToString();
                cboTinhTrang.SelectedValue = Int32.Parse(row.Cells[4].Value.ToString());
                txtGhiChu.Text = row.Cells[3].Value.ToString();
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KhoaMo(false);
            txtMaPhong.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "") return;
            ktThem = false;
            KhoaMo(false);
            macu = txtMaPhong.Text;
            txtMaPhong.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "") return;
            if (MessageBox.Show("Bạn có muốn xóa [ " + txtMaPhong.Text + " ] không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                macu = txtMaPhong.Text;
                PHONGTRO obj = db.PHONGTROs.Where(p => p.MaPhong.Equals(macu)).SingleOrDefault();
                db.PHONGTROs.DeleteOnSubmit(obj);
                db.SubmitChanges();
                XoaTrang();
                LayNguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phòng.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }
            if (txtGiaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá phòng cho thuê.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaPhong.Focus();
                return;
            }
            if (Double.Parse(txtGiaPhong.Text)<=0)
            {
                MessageBox.Show("Bạn chưa nhập giá phòng cho thuê.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaPhong.Focus();
                return;
            }
            if (ktTrungMa() == true)
            {
                MessageBox.Show("Bạn nhập trùng mã phòng trong cơ sở dữ liệu.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPhong.Focus();
                return;
            }

            if (ktThem == true)
            {
                PHONGTRO obj = new PHONGTRO();
                obj.MaPhong = txtMaPhong.Text; obj.GiaPhong = Double.Parse(txtGiaPhong.Text); obj.ThongTin = txtThongTin.Text;
                obj.GhiChu = txtGhiChu.Text; obj.MaTinhTrang = (int) cboTinhTrang.SelectedValue;
                db.PHONGTROs.InsertOnSubmit(obj);
            }
            else
            {
                PHONGTRO objU = db.PHONGTROs.Where(p => p.MaPhong.Equals(macu)).SingleOrDefault();
                objU.MaPhong = txtMaPhong.Text; objU.GiaPhong = Double.Parse(txtGiaPhong.Text); objU.ThongTin = txtThongTin.Text;
                objU.GhiChu = txtGhiChu.Text; objU.MaTinhTrang = (int)cboTinhTrang.SelectedValue;
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
            var kt = db.PHONGTROs.Where(p => p.MaPhong.Equals(txtMaPhong.Text)).ToList();
            if (kt.Count > 0)
            {
                if (ktThem == true)
                    return true;
                else
                   if (kt[0].MaPhong.Equals(macu) == false)
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

        private void frmPhongTro_Load(object sender, EventArgs e)
        {
            KhoaMo(true);
            LayNguonCBO();
            LayNguon();
            
        }
        public void LayNguonCBO()
        {
            var dl = db.TINHTRANGs.ToList();
            cboTinhTrang.DataSource = dl;
            cboTinhTrang.DisplayMember = "TinhTrang1";
            cboTinhTrang.ValueMember = "MaTinhTrang";
        }
    }
}
