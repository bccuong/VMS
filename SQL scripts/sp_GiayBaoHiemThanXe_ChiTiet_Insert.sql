CREATE PROCEDURE [dbo].[sp_GiayBaoHiemThanXe_ChiTiet_Insert]
	@ma_giay varchar(32)
	,@ngay_cap smalldatetime
	,@ngay_het_han smalldatetime
	,@chi_phi numeric(18,0)
	,@ghi_chu ntext
	,@ngay_cap_nhat smalldatetime
	,@nguoi_cap_nhat nchar(32)
	,@trang_thai char(1)
AS
BEGIN
	SET NOCOUNT OFF;

	IF(NOT EXISTS(SELECT ma_giay FROM [dbo].[x_giay_bao_hiem_than_xe_ct] WHERE ma_giay = @ma_giay))
		UPDATE [dbo].[x_giay_bao_hiem_than_xe] SET [ngay_cap_lan_dau] = @ngay_cap WHERE ma_giay = @ma_giay
	
	IF(EXISTS(SELECT ma_giay FROM [dbo].[x_giay_bao_hiem_than_xe_ct] WHERE ma_giay = @ma_giay AND ngay_het_han < getdate()))
		UPDATE [dbo].[x_giay_bao_hiem_than_xe_ct] SET @trang_thai = '0' WHERE ma_giay = @ma_giay AND ngay_het_han < getdate()

	INSERT INTO [dbo].[x_giay_bao_hiem_than_xe_ct]
		([ma_giay]
		,[ngay_cap]
		,[ngay_het_han]
		,[chi_phi]
		,[ghi_chu]
		,[ngay_cap_nhat]
		,[nguoi_cap_nhat]
		,[trang_thai])
	VALUES
		(@ma_giay
		,@ngay_cap
		,@ngay_het_han
		,@chi_phi
		,@ghi_chu
		,@ngay_cap_nhat
		,@nguoi_cap_nhat
		,@trang_thai)
END