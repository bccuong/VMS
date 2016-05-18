using System;
using System.Windows.Forms;
using VMS.DAL.Entity;
using VMS.UI.Interfaces;
using VMS.UI.Presenters;

namespace VMS.UI.Views
{
    public partial class AddEditGiayBaoTriDuongBoChiTietView : Form, IAddEditGiayBaoTriDuongBoChiTietView
    {
        private readonly AddEditGiayBaoTriDuongBoChiTietPresenter _presenter;
        public AddEditGiayBaoTriDuongBoChiTietView(string ma_giay)
        {
            InitializeComponent();
            _presenter = new AddEditGiayBaoTriDuongBoChiTietPresenter(this);
            _presenter.MaGiay = ma_giay;
        }

        public AddEditGiayBaoTriDuongBoChiTietView(giay_dang_ky_ct entity)
            : this(entity.ma_giay)
        {
            _presenter.IsNew = false;
            _presenter.CurrentGiayBaoTriDuongBoChiTiet = entity;
            this.Text = string.Format("CẬP NHẬT");
        }

        private void AddEditGiayBaoTriDuongBoChiTietView_Load(object sender, EventArgs e)
        {
            ActiveControl = dtpNgayCap;
            if (!_presenter.IsNew)
            {
                SetGiayBaoTriDuongBoChiTietToControls(_presenter.CurrentGiayBaoTriDuongBoChiTiet);
                dtpNgayCap.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            giay_dang_ky_ct gdk = GetGiayBaoTriDuongBoChiTiet();

            if (_presenter.IsNew && _presenter.CheckNgayCapIfExisted(gdk.ma_giay, gdk.ngay_cap))
            {
                MessageBox.Show(string.Format("Ngày cấp '{0}' đã tồn tại. Vui lòng chọn ngày khác !", gdk.ngay_cap.ToString("dd/MM/yyyy")), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = dtpNgayCap;
                return;
            }

            if (_presenter.IsNew && !_presenter.CheckNgayCapValid(gdk.ma_giay, gdk.ngay_cap))
            {
                MessageBox.Show(string.Format("Ngày cấp mới '{0}' nhỏ hơn ngày cấp cũ. Vui lòng chọn ngày khác !", gdk.ngay_cap.ToString("dd/MM/yyyy")), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = dtpNgayCap;
                return;
            }

            if (gdk.ngay_cap >= gdk.ngay_het_han)
            {
                MessageBox.Show("Ngày hết hạn phải lớn hơn ngày cấp. Vui lòng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = dtpNgayHetHan;
                return;
            }

            bool result = _presenter.Save(gdk);
            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditGiayBaoTriDuongBoChiTietView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private giay_dang_ky_ct GetGiayBaoTriDuongBoChiTiet()
        {
            giay_dang_ky_ct gdk = new giay_dang_ky_ct();
            gdk.ma_giay = _presenter.MaGiay;
            gdk.ngay_cap = dtpNgayCap.Value.Date;
            gdk.ngay_het_han = dtpNgayHetHan.Value.Date;
            gdk.ghi_chu = txtGhiChu.Text.Trim();
            gdk.ngay_cap_nhat = DateTime.Now;
            gdk.nguoi_cap_nhat = "Admin";
            gdk.trang_thai = chkTinhTrang.Checked ? "1" : "0";

            return gdk;
        }

        private void SetGiayBaoTriDuongBoChiTietToControls(giay_dang_ky_ct entity)
        {
            dtpNgayCap.Value = entity.ngay_cap;
            dtpNgayHetHan.Value = entity.ngay_het_han;
            txtGhiChu.Text = entity.ghi_chu;
            chkTinhTrang.Checked = entity.trang_thai == "1";
        }
    }
}