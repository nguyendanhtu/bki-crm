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
    
    public partial class HT_USER
    {
        public HT_USER()
        {
            this.GD_CHUYEN_TRANG_THAI = new HashSet<GD_CHUYEN_TRANG_THAI>();
            this.GD_NGUOI_QUAN_LY_KHACH_HANG = new HashSet<GD_NGUOI_QUAN_LY_KHACH_HANG>();
            this.HT_USER1 = new HashSet<HT_USER>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid ID_USER_GROUP { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool ACTIVE_YN { get; set; }
        public Nullable<System.Guid> ID_USER_CAP_TREN { get; set; }
        public string HO_TEN_NHAN_VIEN { get; set; }
        public Nullable<System.Guid> ID_PHONG_BAN { get; set; }
        public string SDT01 { get; set; }
        public string SDT02 { get; set; }
        public string EMAIL { get; set; }
        public string ANH_CA_NHAN { get; set; }
    
        public virtual DM_PHONG_BAN DM_PHONG_BAN { get; set; }
        public virtual ICollection<GD_CHUYEN_TRANG_THAI> GD_CHUYEN_TRANG_THAI { get; set; }
        public virtual ICollection<GD_NGUOI_QUAN_LY_KHACH_HANG> GD_NGUOI_QUAN_LY_KHACH_HANG { get; set; }
        public virtual ICollection<HT_USER> HT_USER1 { get; set; }
        public virtual HT_USER HT_USER2 { get; set; }
        public virtual HT_USER_GROUP HT_USER_GROUP { get; set; }
    }
}