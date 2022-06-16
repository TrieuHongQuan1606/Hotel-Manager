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
    public partial class frmDichVu : Form
    {
        DBNhaTroDataContext db = new DBNhaTroDataContext();
        DataGridViewCellMouseEventArgs vt;
        bool ktThem;
        int macu = 1;
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            KhoaMo(true);
            LayNguon();
        }
        public void LayNguon()
        {
            var dl = db.DICHVUs.ToList();
            dgDanhSach.DataSource = dl;
        }

        public void XoaTrang()
        {
            txtID.Text = ""; txtDichVu.Text = ""; txtSoTien.Text = "0";txtGhiChu.Text = "";
        }
        public void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b; cmdXoa.Enabled = b; cmdKetThuc.Enabled = b;

            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;

            txtDichVu.ReadOnly = b; txtSoTien.ReadOnly = b;  txtGhiChu.ReadOnly = b;
        }

        private void dgDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhSach.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtDichVu.Text = row.Cells[1].Value.ToString();
                txtSoTien.Text = row.Cells[2].Value.ToString();
                txtGhiChu.Text = row.Cells[3].Value.ToString();
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KhoaMo(false);
            txtDichVu.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            ktThem = false;
            KhoaMo(false);
            macu = Int32.Parse(txtID.Text);
            txtDichVu.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            if (MessageBox.Show("Bạn có muốn xóa [ " + txtDichVu.Text + " ] không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                macu = Int32.Parse(txtID.Text);
                DICHVU obj = db.DICHVUs.Where(p => p.MaDV == macu).SingleOrDefault();
                db.DICHVUs.DeleteOnSubmit(obj);
                db.SubmitChanges();
                XoaTrang(); txtID.Text = "";
                LayNguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtDichVu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dịch vụ.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDichVu.Focus();
                return;
            }
            if (Double.Parse(txtSoTien.Text)<=0)
            {
                MessageBox.Show("Bạn chưa nhập giá dịch vụ.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTien.Focus();
                return;
            }

            if (ktThem == true)
            {
                DICHVU obj = new DICHVU();
                obj.TenDV = txtDichVu.Text; obj.SoTien = Double.Parse(txtSoTien.Text);
                obj.GhiChu = txtGhiChu.Text;
                db.DICHVUs.InsertOnSubmit(obj);
            }
            else
            {
                DICHVU objU = db.DICHVUs.Where(p => p.MaDV == macu).SingleOrDefault();
                objU.TenDV = txtDichVu.Text; objU.SoTien = Double.Parse(txtSoTien.Text);
                objU.GhiChu = txtGhiChu.Text;
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

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }

        }
    }
}
