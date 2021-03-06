using System.Collections.Generic;
using System.Data;
using VMS.DAL;
using VMS.DAL.Entity;

namespace VMS.BLL
{
    public class TaiSanXeBLL: BaseBLL
    {
        private readonly TaiSanXeData _dataContext;

        public TaiSanXeBLL()
        {
            _dataContext = new TaiSanXeData();
        }

        public List<tai_san_xe> GetAll()
        {
            return _dataContext.GetAll();
        }

        public DataTable GetAllAsDataTable()
        {
            return _dataContext.GetAllAsDataTable();
        }

        public tai_san_xe Get(string ma_xe)
        {
            return _dataContext.GetByMaXe(ma_xe);
        }

        public bool HasExisted(string ma_xe)
        {
            return _dataContext.HasExisted(ma_xe);
        }

        public bool Save(tai_san_xe tsx, bool isNew)
        {
            return _dataContext.Save(tsx, isNew);
        }

        public bool Delete(string ma_xe)
        {
            return _dataContext.Delete(ma_xe);
        }
    }
}
