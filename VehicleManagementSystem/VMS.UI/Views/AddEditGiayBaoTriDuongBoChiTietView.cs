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

        public AddEditGiayBaoTriDuongBoChiTietView(giay_bao_tri_duong_bo_ct entity)
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
            giay_bao_tri_duong_bo_ct entity = GetGiayBaoTriDuongBoChiTiet();

            if (_presenter.IsNew && _presenter.CheckNgayCapIfExisted(entity.ma_giay, entity.ngay_cap))
            {
                MessageBox.Show(string.Format("Ngày cấp '{0}' đã tồn tại. Vui lòng chọn ngày khác !", entity.ngay_cap.ToString("dd/MM/yyyy")), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = dtpNgayCap;
                return;
            }

            if (_presenter.IsNew && !_presenter.CheckNgayCapValid(entity.ma_giay, entity.ngay_cap))
            {
                MessageBox.Show(string.Format("Ngày cấp mới '{0}' nhỏ hơn ngày cấp cũ. Vui lòng chọn ngày khác !", entity.ngay_cap.ToString("dd/MM/yyyy")), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = dtpNgayCap;
                return;
            }

            if (entity.ngay_cap >= entity.ngay_het_han)
            {
                MessageBox.Show("Ngày hết hạn phải lớn hơn ngày cấp. Vui lòng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = dtpNgayHetHan;
                return;
            }

            bool result = _presenter.Save(entity);
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

        private giay_bao_tri_duong_bo_ct GetGiayBaoTriDuongBoChiTiet()
        {
            giay_bao_tri_duong_bo_ct entity = new giay_bao_tri_duong_bo_ct();
            entity.ma_giay = _presenter.MaGiay;
            entity.ngay_cap = dtpNgayCap.Value.Date;
            entity.ngay_het_han = dtpNgayHetHan.Value.Date;
            entity.chi_phi = txtChiPhi.Value;
            entity.ghi_chu = txtGhiChu.Text.Trim();
            entity.ngay_cap_nhat = DateTime.Now;
            entity.nguoi_cap_nhat = "Admin";
            entity.trang_thai = chkTinhTrang.Checked ? "1" : "0";

            return entity;
        }

        private void SetGiayBaoTriDuongBoChiTietToControls(giay_bao_tri_duong_bo_ct entity)
        {
            dtpNgayCap.Value = entity.ngay_cap;
            dtpNgayHetHan.Value = entity.ngay_het_han;
            txtChiPhi.Value = entity.chi_phi;
            txtGhiChu.Text = entity.ghi_chu;
            chkTinhTrang.Checked = entity.trang_thai == "1";
        }
    }
}