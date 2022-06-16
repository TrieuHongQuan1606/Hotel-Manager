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
    public partial class frmLoaiPhong : Form
    {
        DBNhaTroDataContext db = new DBNhaTroDataContext();
        DataGridViewCellMouseEventArgs vt;
        bool ktThem;
        int macu = 1;
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            KhoaMo(true);
            LayNguon();
        }
        public void LayNguon()
        {
            var dl = db.TINHTRANGs.ToList();
            dgDanhSach.DataSource = dl;
        }

        public void XoaTrang()
        {
            txtID.Text = ""; txtTinhTrang.Text = "";
        }
        public void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b; cmdXoa.Enabled = b; cmdKetThuc.Enabled = b;

            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;

            txtTinhTrang.ReadOnly = b;
        }

        private void dgDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhSach.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTinhTrang.Text = row.Cells[1].Value.ToString();
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            ktThem = true;
            XoaTrang();
            KhoaMo(false);
            txtTinhTrang.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            ktThem = false;
            KhoaMo(false);
            macu = Int32.Parse(txtID.Text);
            txtTinhTrang.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            if (MessageBox.Show("Bạn có muốn xóa [ " + txtTinhTrang.Text + " ] không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                macu = Int32.Parse(txtID.Text);
                TINHTRANG obj = db.TINHTRANGs.Where(p => p.MaTinhTrang == macu).SingleOrDefault();
                db.TINHTRANGs.DeleteOnSubmit(obj);
                db.SubmitChanges();
                XoaTrang(); txtID.Text = "";
                LayNguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtTinhTrang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tình trạng phòng thuê.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTinhTrang.Focus();
                return;
            }

            if (ktThem == true)
            {
                TINHTRANG obj = new TINHTRANG();
                obj.TinhTrang1 = txtTinhTrang.Text;
                db.TINHTRANGs.InsertOnSubmit(obj);
            }
            else
            {
                TINHTRANG objU = db.TINHTRANGs.Where(p => p.MaTinhTrang == macu).SingleOrDefault();
                objU.TinhTrang1 = txtTinhTrang.Text;
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
    }
}
