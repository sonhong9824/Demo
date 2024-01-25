namespace WindowsFormsApp1
{
    partial class FGiangVien
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
            this.btnSV = new System.Windows.Forms.Button();
            this.dtpnamSinh = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gv2 = new System.Windows.Forms.DataGridView();
            this.lblngaySinh = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSV
            // 
            this.btnSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSV.Location = new System.Drawing.Point(855, 434);
            this.btnSV.Name = "btnSV";
            this.btnSV.Size = new System.Drawing.Size(147, 53);
            this.btnSV.TabIndex = 25;
            this.btnSV.Text = "Sinh viên";
            this.btnSV.UseVisualStyleBackColor = true;
            this.btnSV.Click += new System.EventHandler(this.btnSV_Click);
            // 
            // dtpnamSinh
            // 
            this.dtpnamSinh.CustomFormat = "dd/MM/yyyy";
            this.dtpnamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpnamSinh.Location = new System.Drawing.Point(232, 269);
            this.dtpnamSinh.Name = "dtpnamSinh";
            this.dtpnamSinh.Size = new System.Drawing.Size(230, 22);
            this.dtpnamSinh.TabIndex = 24;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(232, 213);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(230, 22);
            this.txtCMND.TabIndex = 23;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(232, 164);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(230, 22);
            this.txtDiachi.TabIndex = 22;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(232, 111);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(230, 22);
            this.txtTen.TabIndex = 21;
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(352, 345);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 53);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(193, 345);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 53);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(27, 345);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 53);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gv2
            // 
            this.gv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv2.Location = new System.Drawing.Point(480, 40);
            this.gv2.Name = "gv2";
            this.gv2.RowHeadersWidth = 51;
            this.gv2.RowTemplate.Height = 24;
            this.gv2.Size = new System.Drawing.Size(607, 358);
            this.gv2.TabIndex = 17;
            this.gv2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv2_CellClick);
            // 
            // lblngaySinh
            // 
            this.lblngaySinh.AutoSize = true;
            this.lblngaySinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaySinh.Location = new System.Drawing.Point(23, 267);
            this.lblngaySinh.Name = "lblngaySinh";
            this.lblngaySinh.Size = new System.Drawing.Size(186, 24);
            this.lblngaySinh.TabIndex = 16;
            this.lblngaySinh.Text = "Ngày tháng năm sinh";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(23, 213);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(63, 24);
            this.lblCMND.TabIndex = 15;
            this.lblCMND.Text = "CMND";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(23, 161);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(66, 24);
            this.lblDiachi.TabIndex = 14;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(23, 111);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(90, 24);
            this.lblTen.TabIndex = 13;
            this.lblTen.Text = "Họ và tên";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(103, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 49);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Giảng Viên";
            // 
            // FGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 525);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSV);
            this.Controls.Add(this.dtpnamSinh);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gv2);
            this.Controls.Add(this.lblngaySinh);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblTen);
            this.Name = "FGiangVien";
            this.Text = "FGiangVien";
            this.Load += new System.EventHandler(this.FGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSV;
        private System.Windows.Forms.DateTimePicker dtpnamSinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView gv2;
        private System.Windows.Forms.Label lblngaySinh;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblTitle;
    }
}