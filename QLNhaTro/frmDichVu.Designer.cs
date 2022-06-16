namespace QLNhaTro
{
    partial class frmDichVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDichVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmdKetThuc = new System.Windows.Forms.Button();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDanhSach
            // 
            this.dgDanhSach.AllowUserToAddRows = false;
            this.dgDanhSach.AllowUserToDeleteRows = false;
            this.dgDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgDanhSach.Location = new System.Drawing.Point(10, 50);
            this.dgDanhSach.MultiSelect = false;
            this.dgDanhSach.Name = "dgDanhSach";
            this.dgDanhSach.ReadOnly = true;
            this.dgDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDanhSach.Size = new System.Drawing.Size(790, 310);
            this.dgDanhSach.TabIndex = 1;
            this.dgDanhSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhSach_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDV";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDV";
            this.Column2.HeaderText = "Tên Dịch Vụ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoTien";
            this.Column3.HeaderText = "Giá Tiền";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GhiChu";
            this.Column4.HeaderText = "Ghi Chú";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC DỊCH VỤ CUNG CẤP";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(510, 370);
            this.txtSoTien.MaxLength = 10;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(290, 26);
            this.txtSoTien.TabIndex = 5;
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTien_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá tiền :";
            // 
            // txtDichVu
            // 
            this.txtDichVu.Location = new System.Drawing.Point(100, 370);
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.Size = new System.Drawing.Size(320, 26);
            this.txtDichVu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dịch vụ :";
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(210, 450);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(100, 30);
            this.cmdSua.TabIndex = 9;
            this.cmdSua.Text = "Cập nhật";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(320, 450);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(100, 30);
            this.cmdXoa.TabIndex = 10;
            this.cmdXoa.Text = "Xóa bỏ";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(100, 450);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(100, 30);
            this.cmdThem.TabIndex = 8;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(30, 450);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(40, 26);
            this.txtID.TabIndex = 14;
            this.txtID.Visible = false;
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Location = new System.Drawing.Point(690, 450);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(110, 30);
            this.cmdKetThuc.TabIndex = 13;
            this.cmdKetThuc.Text = "Kết thúc";
            this.cmdKetThuc.UseVisualStyleBackColor = true;
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(560, 450);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(110, 30);
            this.cmdKhong.TabIndex = 12;
            this.cmdKhong.Text = "Không ghi";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(440, 450);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(110, 30);
            this.cmdGhi.TabIndex = 11;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(100, 410);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(700, 26);
            this.txtGhiChu.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ghi chú : ";
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 491);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdGhi);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDichVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgDanhSach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục Dịch Vụ";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button cmdKetThuc;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}