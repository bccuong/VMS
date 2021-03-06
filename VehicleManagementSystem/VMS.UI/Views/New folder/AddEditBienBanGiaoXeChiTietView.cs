using System;
using System.Data;
using System.Windows.Forms;
using VMS.DAL.Entity;
using VMS.UI.Interfaces;
using VMS.UI.Presenters;

namespace VMS.UI.Views
{
    public partial class AddEditBienBanGiaoXeChiTietView : Form, IAddEditBienBanGiaoXeChiTietView
    {
        private readonly AddEditBienBanGiaoXeChiTietPresenter _presenter;
        public AddEditBienBanGiaoXeChiTietView(string ma_xe)
        {
            InitializeComponent();
            _presenter = new AddEditBienBanGiaoXeChiTietPresenter(this);
            _presenter.MaXe = ma_xe;
        }

        public AddEditBienBanGiaoXeChiTietView(bien_ban_giao_xe_ct entity)
            : this(entity.ma_xe)
        {
            if (entity != null)
            {
                _presenter.IsNew = false;
                _presenter.CurrentBienBanGiaoXeChiTiet = entity;
                this.Text = string.Format("CẬP NHẬT '{0}'", entity.ten_ccdc);
            }
        }

        private void AddEditBienBanGiaoXeChiTietView_Load(object sender, EventArgs e)
        {
            ActiveControl = cboTaiSan;
            _presenter.LoadBienBanGiaoXeChiTiet();

            if (!_presenter.IsNew)
            {
                SetBienBanGiaoXeChiTietToControls(_presenter.CurrentBienBanGiaoXeChiTiet);
                cboTaiSan.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bien_ban_giao_xe_ct BienBanGiaoXeChiTiet = GetBienBanGiaoXeChiTiet();

            if (string.IsNullOrEmpty(BienBanGiaoXeChiTiet.ma_ccdc))
            {
                MessageBox.Show("Công cụ dụng cụ không được trống. Vui lòng chọn phụ tùng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = cboTaiSan;
                return;
            }
            if (BienBanGiaoXeChiTiet.so_luong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0. Vui lòng nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = txtSoLuong;
                return;
            }

            if (_presenter.IsNew && _presenter.CheckBienBanGiaoXeChiTietIfExisted(BienBanGiaoXeChiTiet.ma_xe, BienBanGiaoXeChiTiet.ma_tai_san))
            {
                MessageBox.Show("Phụ tùng đã được sử dụng. Vui lòng cập nhật lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = cboTaiSan;
                return;
            }

            bool result = _presenter.Save(BienBanGiaoXeChiTiet);
            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditBienBanGiaoXeChiTietView_KeyDown(object sender, KeyEventArgs e)
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

        private bien_ban_giao_xe_ct GetBienBanGiaoXeChiTiet()
        {
            bien_ban_giao_xe_ct BienBanGiaoXeChiTiet = new bien_ban_giao_xe_ct();
            BienBanGiaoXeChiTiet.ma_xe = _presenter.MaXe;
            BienBanGiaoXeChiTiet.ma_tai_san = cboTaiSan.SelectedValue.ToString();
            BienBanGiaoXeChiTiet.so_luong = byte.Parse(txtSoLuong.Text);
            BienBanGiaoXeChiTiet.so_km_da_su_dung = txtSoKmDaSuDung.Value;
            BienBanGiaoXeChiTiet.tinh_trang = (byte) (chkTinhTrang.Checked ? 1 : 0);

            return BienBanGiaoXeChiTiet;
        }

        private void SetBienBanGiaoXeChiTietToControls(bien_ban_giao_xe_ct entity)
        {
            cboTaiSan.SelectedValue = entity.ma_tai_san;
            txtSoLuong.Value = entity.so_luong;
            txtSoKmDaSuDung.Value = entity.so_km_da_su_dung;
            chkTinhTrang.Checked = entity.tinh_trang == 1;
        }

        #region IAddEditBienBanGiaoXeChiTietView Members

        public void LoadTaiSanMMTB(DataTable dt)
        {
            cboTaiSan.DataSource = dt;
            cboTaiSan.DisplayMember = "ten_tai_san";
            cboTaiSan.ValueMember = "ma_tai_san";
        }

        #endregion
    }
}