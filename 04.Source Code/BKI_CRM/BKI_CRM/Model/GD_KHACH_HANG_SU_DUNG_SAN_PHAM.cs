//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BKI_CRM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GD_KHACH_HANG_SU_DUNG_SAN_PHAM
    {
        public GD_KHACH_HANG_SU_DUNG_SAN_PHAM()
        {
            this.GD_CHUYEN_TRANG_THAI = new HashSet<GD_CHUYEN_TRANG_THAI>();
            this.GD_NGUOI_QUAN_LY_KHACH_HANG = new HashSet<GD_NGUOI_QUAN_LY_KHACH_HANG>();
            this.GD_THONG_TIN_HOP_DONG = new HashSet<GD_THONG_TIN_HOP_DONG>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid ID_KHACH_HANG { get; set; }
        public Nullable<System.Guid> ID_SAN_PHAM { get; set; }
        public string TEN_SAN_PHAM { get; set; }
        public string NGUOI_GIOI_THIEU { get; set; }
    
        public virtual DM_KHACH_HANG DM_KHACH_HANG { get; set; }
        public virtual DM_SAN_PHAM DM_SAN_PHAM { get; set; }
        public virtual ICollection<GD_CHUYEN_TRANG_THAI> GD_CHUYEN_TRANG_THAI { get; set; }
        public virtual ICollection<GD_NGUOI_QUAN_LY_KHACH_HANG> GD_NGUOI_QUAN_LY_KHACH_HANG { get; set; }
        public virtual ICollection<GD_THONG_TIN_HOP_DONG> GD_THONG_TIN_HOP_DONG { get; set; }
    }
}
