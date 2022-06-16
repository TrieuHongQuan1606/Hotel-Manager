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
    public partial class frmQLChuNha : Form
    {
        DBNhaTroDataContext db = new DBNhaTroDataContext();
        DataGridViewCellMouseEventArgs vt;
        bool ktThem;
        int macu=1;
        public frmQLChuNha()
        {
            InitializeComponent();
        }

        private void frmQLChuNha_Load(object sender, EventArgs e)
        {
            KhoaMo(true);
            LayNguon();
        }

        public void LayNguon()
        {
            var dl = db.CHUNHAs.ToList();
            dgDanhSach.DataSource = dl;
        }

        public void XoaTrang()
        {
            txtID.Text = "";txtHoTen.Text = "";txtSDT.Text = "";
            txtDiaChi.Text = "";txtGhiChu.Text = "";
        }
        public void KhoaMo(bool b)
        {
            dgDanhSach.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b;cmdXoa.Enabled = b;cmdKetThuc.Enabled = b;

            cmdGhi.Enabled = !b; cmdKhong.Enabled = !b;

            txtHoTen.ReadOnly = b; txtSDT.ReadOnly = b; txtDiaChi.ReadOnly = b; txtGhiChu.ReadOnly = b;
        }

        private void dgDanhSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhSach.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhSach.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtGhiChu.Text = row.Cells[4].Value.ToString();
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
            if (txtID.Text == "") return;
            ktThem = false;
            KhoaMo(false);
            macu = Int32.Parse(txtID.Text);
            txtHoTen.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            if (MessageBox.Show("Bạn có muốn xóa hồ sơ [ " + txtHoTen.Text + " ] không?","Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                macu= Int32.Parse(txtID.Text);
                CHUNHA obj = db.CHUNHAs.Where(p => p.IDCN == macu).SingleOrDefault();
                db.CHUNHAs.DeleteOnSubmit(obj);
                db.SubmitChanges();
                XoaTrang(); txtID.Text = "";
                LayNguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text== ""){
                MessageBox.Show("Bạn chưa nhập họ tên.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (ktThem == true)
            {
                CHUNHA obj = new CHUNHA();
                obj.HoTen = txtHoTen.Text; obj.SDT = txtSDT.Text;
                obj.DiaChi = txtDiaChi.Text; obj.GhiChu = txtGhiChu.Text;
                db.CHUNHAs.InsertOnSubmit(obj);
            }
            else
            {
                CHUNHA objU = db.CHUNHAs.Where(p => p.IDCN == macu).SingleOrDefault();
                objU.HoTen = txtHoTen.Text; objU.SDT = txtSDT.Text;
                objU.DiaChi = txtDiaChi.Text; objU.GhiChu = txtGhiChu.Text;
            }
            db.SubmitChanges();            
            KhoaMo(true);
            LayNguon();
            try
            {
                XoaTrang();
                dgDanhSach_CellMouseClick(sender, vt);
            } catch (Exception ex) { }
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
    }
}
