CREATE PROCEDURE [dbo].[sp_TaiSanXe_Insert]
	@ma_xe varchar(32)
	,@bien_so varchar(32)
	,@hang_san_xuat nvarchar(50)
	,@loai_xe varchar(32)
	,@ma_lts nchar(32)
	,@nam_san_xuat smallint
	,@so_nam_su_dung tinyint
	,@so_may char(32)
	,@so_khung char(32)
	,@mau nvarchar(32)
	,@binh_nhien_lieu nchar(15)
	,@loai_nhien_lieu nvarchar(32)
	,@trong_tai_the_tich numeric(18,0)
	,@trong_tai_khoi_luong numeric(18,0)
	,@tong_trong_luong numeric(18,0)
	,@nguyen_gia numeric(18,0)
	,@gia_tri_khau_hao numeric(18,0)
	,@ti_le_khau_hao numeric(16,2)
	,@gia_tri_con_lai numeric(18,0)
	,@hinh_anh image
	,@ghi_chu nvarchar(200)
	,@ngay_cap_nhat datetime
	,@nguoi_cap_nhat nvarchar(50)
	,@ngay_tao datetime
	,@nguoi_tao nvarchar(50)
	,@status char(1)
AS
BEGIN
	SET NOCOUNT OFF;
	INSERT INTO [dbo].[tai_san_xe]
           ([ma_xe]
           ,[bien_so]
           ,[hang_san_xuat]
           ,[loai_xe]
           ,[ma_lts]
           ,[nam_san_xuat]
           ,[so_nam_su_dung]
           ,[so_may]
           ,[so_khung]
           ,[mau]
           ,[binh_nhien_lieu]
           ,[loai_nhien_lieu]
           ,[trong_tai_the_tich]
           ,[trong_tai_khoi_luong]
           ,[tong_trong_luong]
           ,[nguyen_gia]
           ,[gia_tri_khau_hao]
           ,[ti_le_khau_hao]
           ,[gia_tri_con_lai]
           ,[hinh_anh]
           ,[ghi_chu]
           ,[ngay_cap_nhat]
           ,[nguoi_cap_nhat]
           ,[ngay_tao]
           ,[nguoi_tao]
           ,[status])
     VALUES
           (@ma_xe
			,@bien_so
			,@hang_san_xuat
			,@loai_xe
			,@ma_lts
			,@nam_san_xuat
			,@so_nam_su_dung
			,@so_may
			,@so_khung
			,@mau
			,@binh_nhien_lieu
			,@loai_nhien_lieu
			,@trong_tai_the_tich
			,@trong_tai_khoi_luong
			,@tong_trong_luong
			,@nguyen_gia
			,@gia_tri_khau_hao
			,@ti_le_khau_hao
			,@gia_tri_con_lai
			,@hinh_anh
			,@ghi_chu
			,@ngay_cap_nhat
			,@nguoi_cap_nhat
			,@ngay_tao
			,@nguoi_tao
			,@status)
END


