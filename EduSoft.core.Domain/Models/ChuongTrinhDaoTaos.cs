using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateDBEduSoft.Models
{
    public partial class ChuongTrinhDaoTaos
    {
        public string Id { get; set; }
        public string MaChuongTrinhDaoTao { get; set; }
        public string TenChuongTrinhDaoTao { get; set; }
        public string HeDaoTao { get; set; }
        public int ThoiGianDaoTao { get; set; }
        public int SoTinChi { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }

    }
}
