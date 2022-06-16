namespace QLNhaTro
{
    partial class frmLoaiPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdKetThuc = new System.Windows.Forms.Button();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Column2});
            this.dgDanhSach.Location = new System.Drawing.Point(10, 50);
            this.dgDanhSach.MultiSelect = false;
            this.dgDanhSach.Name = "dgDanhSach";
            this.dgDanhSach.ReadOnly = true;
            this.dgDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDanhSach.Size = new System.Drawing.Size(650, 230);
            this.dgDanhSach.TabIndex = 1;
            this.dgDanhSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhSach_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÌNH TRẠNG PHÒNG THUÊ";
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Location = new System.Drawing.Point(570, 340);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(90, 30);
            this.cmdKetThuc.TabIndex = 10;
            this.cmdKetThuc.Text = "Kết thúc";
            this.cmdKetThuc.UseVisualStyleBackColor = true;
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(460, 340);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(100, 30);
            this.cmdKhong.TabIndex = 9;
            this.cmdKhong.Text = "Không ghi";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(380, 340);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(70, 30);
            this.cmdGhi.TabIndex = 8;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(110, 300);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(550, 26);
            this.txtTinhTrang.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tình trạng :";
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(190, 340);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(90, 30);
            this.cmdSua.TabIndex = 6;
            this.cmdSua.Text = "Cập nhật";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(290, 340);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(80, 30);
            this.cmdXoa.TabIndex = 7;
            this.cmdXoa.Text = "Xóa bỏ";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(110, 340);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(70, 30);
            this.cmdThem.TabIndex = 5;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(20, 340);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(40, 26);
            this.txtID.TabIndex = 4;
            this.txtID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTinhTrang";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TinhTrang1";
            this.Column2.HeaderText = "Tình Trạng Phòng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 580;
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 396);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdGhi);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgDanhSach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tình Trạng Phòng Thuê";
            this.Load += new System.EventHandler(this.frmLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdKetThuc;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}