using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using VMS.DAL.Entity;
using VMS.Helper;

namespace VMS.DAL
{
    public class TaiSanXeData
    {
        public TaiSanXeData()
        {
            DataFactory.CreateConnection();
        }

        public List<tai_san_xe> GetAll()
        {
            SqlCommand cmd = DataFactory.CreateCommand("SELECT * FROM tai_san_xe ORDER BY ngay_cap_nhat DESC");
            SqlDataAdapter da = DataFactory.CreateAdapter(cmd);
            DataTable dt = new DataTable("tai_san_xe");
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return ConvertionHelper.ToList<tai_san_xe>(dt);
            }
            return null;
        }

        public DataTable GetAllAsDataTable()
        {
            SqlCommand cmd = DataFactory.CreateCommand("SELECT tsx.*, lts.ten_lts FROM tai_san_xe tsx INNER JOIN dm_loai_tai_san lts ON tsx.ma_lts = lts.ma_lts ORDER BY ngay_cap_nhat DESC");
            SqlDataAdapter da = DataFactory.CreateAdapter(cmd);
            DataTable dt = new DataTable("tai_san_xe");
            da.Fill(dt);

            return dt;
        }

        public tai_san_xe GetByMaXe(string ma_xe)
        {
            SqlCommand cmd = DataFactory.CreateCommand(string.Format("SELECT tsx.*, lts.ten_lts FROM tai_san_xe tsx INNER JOIN dm_loai_tai_san lts ON tsx.ma_lts = lts.ma_lts WHERE tsx.ma_xe = '{0}'", ma_xe));
            SqlDataAdapter da = DataFactory.CreateAdapter(cmd);
            DataTable dt = new DataTable("tai_san_xe");
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return ConvertionHelper.ToEntity<tai_san_xe>(dt.Rows[0]);
            }
            return null;
        }

        public bool HasExisted(string ma_xe)
        {
            SqlCommand cmd = DataFactory.CreateCommand(string.Format("SELECT ma_xe FROM tai_san_xe WHERE ma_xe = '{0}'", ma_xe));
            SqlDataAdapter da = DataFactory.CreateAdapter(cmd);
            DataTable dt = new DataTable("tai_san_xe");
            da.Fill(dt);

            return dt.Rows.Count > 0;
        }

        public bool Save(tai_san_xe tsx, bool isNew)
        {
            string sqlStr = "sp_TaiSanXe_Insert";
            if (!isNew)
                sqlStr = "sp_TaiSanXe_Update";

            SqlCommand cmd = DataFactory.CreateCommand(sqlStr);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ma_xe", SqlDbType.VarChar).Value = tsx.ma_xe;
            cmd.Parameters.Add("@bien_so", SqlDbType.VarChar).Value = tsx.bien_so;
            cmd.Parameters.Add("@hang_san_xuat", SqlDbType.NVarChar).Value = tsx.hang_san_xuat;
            cmd.Parameters.Add("@loai_xe", SqlDbType.VarChar).Value = tsx.loai_xe;
            cmd.Parameters.Add("@ma_lts", SqlDbType.NChar).Value = tsx.ma_lts;
            cmd.Parameters.Add("@nam_san_xuat", SqlDbType.SmallInt).Value = tsx.nam_san_xuat;
            cmd.Parameters.Add("@so_nam_su_dung", SqlDbType.TinyInt).Value = tsx.so_nam_su_dung;
            cmd.Parameters.Add("@so_may", SqlDbType.Char).Value = tsx.so_may;
            cmd.Parameters.Add("@so_khung", SqlDbType.Char).Value = tsx.so_khung;
            cmd.Parameters.Add("@mau", SqlDbType.NVarChar).Value = tsx.mau;
            cmd.Parameters.Add("@binh_nhien_lieu", SqlDbType.NChar).Value = tsx.binh_nhien_lieu;
            cmd.Parameters.Add("@loai_nhien_lieu", SqlDbType.NVarChar).Value = tsx.loai_nhien_lieu;
            cmd.Parameters.Add("@trong_tai_the_tich", SqlDbType.Decimal).Value = tsx.trong_tai_the_tich;
            cmd.Parameters.Add("@trong_tai_khoi_luong", SqlDbType.Decimal).Value = tsx.trong_tai_khoi_luong;
            cmd.Parameters.Add("@tong_trong_luong", SqlDbType.Decimal).Value = tsx.tong_trong_luong;
            cmd.Parameters.Add("@nguyen_gia", SqlDbType.Decimal).Value = tsx.nguyen_gia;
            cmd.Parameters.Add("@gia_tri_khau_hao", SqlDbType.Decimal).Value = tsx.gia_tri_khau_hao;
            cmd.Parameters.Add("@ti_le_khau_hao", SqlDbType.Decimal).Value = tsx.ti_le_khau_hao;
            cmd.Parameters.Add("@gia_tri_con_lai", SqlDbType.Decimal).Value = tsx.gia_tri_con_lai;
            cmd.Parameters.Add("@hinh_anh", SqlDbType.Image).Value = tsx.hinh_anh ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ghi_chu", SqlDbType.NVarChar).Value = tsx.ghi_chu;
            cmd.Parameters.Add("@ngay_cap_nhat", SqlDbType.DateTime).Value = tsx.ngay_cap_nhat;
            cmd.Parameters.Add("@nguoi_cap_nhat", SqlDbType.NVarChar).Value = tsx.nguoi_cap_nhat;
            if (isNew)
            {
                cmd.Parameters.Add("@ngay_tao", SqlDbType.DateTime).Value = tsx.ngay_tao;
                cmd.Parameters.Add("@nguoi_tao", SqlDbType.NVarChar).Value = tsx.nguoi_tao;
            }
            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = tsx.status;

            bool result = DataFactory.ExecuteNonQuery(cmd);
            return result;
        }

        public bool Delete(string ma_xe)
        {
            SqlCommand cmd = DataFactory.CreateCommand("sp_TaiSanXe_Delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ma_xe", SqlDbType.VarChar).Value = ma_xe;
            bool result = DataFactory.ExecuteNonQuery(cmd);
            return result;
        }
    }
}
