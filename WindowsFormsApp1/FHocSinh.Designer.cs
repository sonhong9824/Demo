namespace WindowsFormsApp1
{
    partial class FHocSinh
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
            this.lblTen = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblngaySinh = new System.Windows.Forms.Label();
            this.gv1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.dtpnamSinh = new System.Windows.Forms.DateTimePicker();
            this.btnGV = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(12, 108);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(90, 24);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Họ và tên";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(14, 161);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(66, 24);
            this.lblDiachi.TabIndex = 1;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(12, 210);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(63, 24);
            this.lblCMND.TabIndex = 2;
            this.lblCMND.Text = "CMND";
            // 
            // lblngaySinh
            // 
            this.lblngaySinh.AutoSize = true;
            this.lblngaySinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaySinh.Location = new System.Drawing.Point(12, 260);
            this.lblngaySinh.Name = "lblngaySinh";
            this.lblngaySinh.Size = new System.Drawing.Size(186, 24);
            this.lblngaySinh.TabIndex = 3;
            this.lblngaySinh.Text = "Ngày tháng năm sinh";
            // 
            // gv1
            // 
            this.gv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv1.Location = new System.Drawing.Point(480, 33);
            this.gv1.Name = "gv1";
            this.gv1.RowHeadersWidth = 51;
            this.gv1.RowTemplate.Height = 24;
            this.gv1.Size = new System.Drawing.Size(609, 358);
            this.gv1.TabIndex = 4;
            this.gv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv1_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(32, 338);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 53);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(196, 338);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 53);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(361, 338);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 53);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(208, 111);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(230, 22);
            this.txtTen.TabIndex = 8;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(208, 161);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(230, 22);
            this.txtDiachi.TabIndex = 9;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(208, 210);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(230, 22);
            this.txtCMND.TabIndex = 10;
            // 
            // dtpnamSinh
            // 
            this.dtpnamSinh.CustomFormat = "dd/MM/yyyy";
            this.dtpnamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpnamSinh.Location = new System.Drawing.Point(208, 260);
            this.dtpnamSinh.Name = "dtpnamSinh";
            this.dtpnamSinh.Size = new System.Drawing.Size(230, 22);
            this.dtpnamSinh.TabIndex = 11;
            // 
            // btnGV
            // 
            this.btnGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGV.Location = new System.Drawing.Point(844, 432);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(138, 53);
            this.btnGV.TabIndex = 12;
            this.btnGV.Text = "Giảng Viên";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(118, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 49);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Học Sinh";
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 525);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGV);
            this.Controls.Add(this.dtpnamSinh);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gv1);
            this.Controls.Add(this.lblngaySinh);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblTen);
            this.Name = "FHocSinh";
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblngaySinh;
        private System.Windows.Forms.DataGridView gv1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.DateTimePicker dtpnamSinh;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Label lblTitle;
    }
}

