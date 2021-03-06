namespace VMS.UI.Views
{
    partial class AddEditGiayBaoHiemNhanSuView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNgayCapDauTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayCapDauTien = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNhacNhoTruocNgay = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDonVi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaGiay = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhacNhoTruocNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 455);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.txtNgayCapDauTien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpNgayCapDauTien);
            this.panel1.Controls.Add(this.btnClearImage);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.picHinhAnh);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtNhacNhoTruocNgay);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboDonVi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.chkStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaGiay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 389);
            this.panel1.TabIndex = 1;
            // 
            // txtNgayCapDauTien
            // 
            this.txtNgayCapDauTien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNgayCapDauTien.Location = new System.Drawing.Point(227, 157);
            this.txtNgayCapDauTien.Name = "txtNgayCapDauTien";
            this.txtNgayCapDauTien.ReadOnly = true;
            this.txtNgayCapDauTien.Size = new System.Drawing.Size(131, 26);
            this.txtNgayCapDauTien.TabIndex = 101;
            this.txtNgayCapDauTien.TabStop = false;
            this.txtNgayCapDauTien.Text = "N/A";
            this.txtNgayCapDauTien.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "ngày.";
            // 
            // dtpNgayCapDauTien
            // 
            this.dtpNgayCapDauTien.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayCapDauTien.Enabled = false;
            this.dtpNgayCapDauTien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayCapDauTien.Location = new System.Drawing.Point(227, 157);
            this.dtpNgayCapDauTien.MaxDate = new System.DateTime(2079, 6, 6, 0, 0, 0, 0);
            this.dtpNgayCapDauTien.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgayCapDauTien.Name = "dtpNgayCapDauTien";
            this.dtpNgayCapDauTien.Size = new System.Drawing.Size(131, 26);
            this.dtpNgayCapDauTien.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(541, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(263, 20);
            this.label22.TabIndex = 97;
            this.label22.Text = "(Nhấp vào khung dưới để chọn hình)";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.Location = new System.Drawing.Point(227, 244);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(300, 100);
            this.txtGhiChu.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(66, 244);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 20);
            this.label21.TabIndex = 96;
            this.label21.Text = "Ghi chú:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 85;
            this.label11.Text = "Trạng thái:";
            // 
            // txtNhacNhoTruocNgay
            // 
            this.txtNhacNhoTruocNgay.Location = new System.Drawing.Point(227, 199);
            this.txtNhacNhoTruocNgay.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtNhacNhoTruocNgay.Name = "txtNhacNhoTruocNgay";
            this.txtNhacNhoTruocNgay.Size = new System.Drawing.Size(131, 26);
            this.txtNhacNhoTruocNgay.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Ngày cấp lần đầu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Nhắc nhở trước";
            // 
            // cboDonVi
            // 
            this.cboDonVi.FormattingEnabled = true;
            this.cboDonVi.Location = new System.Drawing.Point(227, 114);
            this.cboDonVi.Name = "cboDonVi";
            this.cboDonVi.Size = new System.Drawing.Size(300, 28);
            this.cboDonVi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "Đơn vị:";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(227, 34);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(22, 21);
            this.chkStatus.TabIndex = 0;
            this.chkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Mã giấy:";
            // 
            // txtMaGiay
            // 
            this.txtMaGiay.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaGiay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaGiay.Location = new System.Drawing.Point(227, 73);
            this.txtMaGiay.Name = "txtMaGiay";
            this.txtMaGiay.Size = new System.Drawing.Size(131, 26);
            this.txtMaGiay.TabIndex = 1;
            this.txtMaGiay.WordWrap = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;*.bmp;";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Chọn hình xe";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundImage = global::VMS.UI.Properties.Resources.exit;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(831, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 54);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = global::VMS.UI.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(770, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 54);
            this.btnSave.TabIndex = 1;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearImage
            // 
            this.btnClearImage.BackgroundImage = global::VMS.UI.Properties.Resources.delete;
            this.btnClearImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearImage.FlatAppearance.BorderSize = 0;
            this.btnClearImage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnClearImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearImage.Location = new System.Drawing.Point(810, 32);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(24, 24);
            this.btnClearImage.TabIndex = 98;
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Visible = false;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHinhAnh.Location = new System.Drawing.Point(545, 57);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(300, 287);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 91;
            this.picHinhAnh.TabStop = false;
            this.picHinhAnh.Click += new System.EventHandler(this.picHinhAnh_Click);
            // 
            // AddEditGiayBaoHiemNhanSuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditGiayBaoHiemNhanSuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM MỚI";
            this.Load += new System.EventHandler(this.AddEditGiayBaoHiemNhanSuView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddEditGiayBaoHiemNhanSuView_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhacNhoTruocNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtNhacNhoTruocNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDonVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaGiay;
        private System.Windows.Forms.DateTimePicker dtpNgayCapDauTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNgayCapDauTien;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}