using System;
using System.Data;
using System.Windows.Forms;
using VMS.DAL.Entity;
using VMS.UI.Interfaces;
using VMS.UI.Presenters;

namespace VMS.UI.Views
{
    public partial class AddEditPhuTungView : Form, IAddEditPhuTungView
    {
        private readonly AddEditPhuTungPresenter _presenter;
        public AddEditPhuTungView(string ma_xe)
        {
            InitializeComponent();
            _presenter = new AddEditPhuTungPresenter(this);
            _presenter.MaXe = ma_xe;
        }

        public AddEditPhuTungView(phu_tung entity)
            : this(entity.ma_xe)
        {
            if (entity != null)
            {
                _presenter.IsNew = false;
                _presenter.CurrentPhuTung = entity;
                this.Text = string.Format("CẬP NHẬT '{0}'", entity.ten_tai_san);
            }
        }

        private void AddEditPhuTungView_Load(object sender, EventArgs e)
        {
            ActiveControl = cboTaiSan;
            _presenter.LoadPhuTung();

            if (!_presenter.IsNew)
            {
                SetPhuTungToControls(_presenter.CurrentPhuTung);
                cboTaiSan.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            phu_tung entity = GetPhuTung();

            if (string.IsNullOrEmpty(entity.ma_tai_san))
            {
                MessageBox.Show("Phụ tùng không được trống. Vui lòng chọn phụ tùng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = cboTaiSan;
                return;
            }
            if (entity.so_luong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0. Vui lòng nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = txtSoLuong;
                return;
            }

            if (_presenter.IsNew && _presenter.CheckPhuTungIfExisted(entity.ma_xe, entity.ma_tai_san))
            {
                MessageBox.Show("Phụ tùng đã được sử dụng. Vui lòng cập nhật lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = cboTaiSan;
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

        private void AddEditPhuTungView_KeyDown(object sender, KeyEventArgs e)
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

        private phu_tung GetPhuTung()
        {
            phu_tung entity = new phu_tung();
            entity.ma_xe = _presenter.MaXe;
            entity.ma_tai_san = cboTaiSan.SelectedValue.ToString();
            entity.so_luong = byte.Parse(txtSoLuong.Text);
            entity.so_km_da_su_dung = txtSoKmDaSuDung.Value;
            entity.tinh_trang = (byte) (chkTinhTrang.Checked ? 1 : 0);

            return entity;
        }

        private void SetPhuTungToControls(phu_tung entity)
        {
            cboTaiSan.SelectedValue = entity.ma_tai_san;
            txtSoLuong.Value = entity.so_luong;
            txtSoKmDaSuDung.Value = entity.so_km_da_su_dung;
            chkTinhTrang.Checked = entity.tinh_trang == 1;
        }

        #region IAddEditPhuTungView Members

        public void LoadTaiSanMMTB(DataTable dt)
        {
            cboTaiSan.DataSource = dt;
            cboTaiSan.DisplayMember = "ten_tai_san";
            cboTaiSan.ValueMember = "ma_tai_san";
        }

        #endregion
    }
}