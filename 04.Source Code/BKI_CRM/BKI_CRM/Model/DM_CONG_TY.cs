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
    
    public partial class DM_CONG_TY
    {
        public DM_CONG_TY()
        {
            this.DM_KHACH_HANG = new HashSet<DM_KHACH_HANG>();
            this.DM_NHOM_SAN_PHAM = new HashSet<DM_NHOM_SAN_PHAM>();
            this.DM_PHONG_BAN = new HashSet<DM_PHONG_BAN>();
            this.DM_TRANG_THAI = new HashSet<DM_TRANG_THAI>();
            this.HT_USER_GROUP = new HashSet<HT_USER_GROUP>();
        }
    
        public System.Guid ID { get; set; }
        public string TEN_CONG_TY { get; set; }
        public int SO_LUONG_USER { get; set; }
    
        public virtual DM_ACTION DM_ACTION { get; set; }
        public virtual ICollection<DM_KHACH_HANG> DM_KHACH_HANG { get; set; }
        public virtual ICollection<DM_NHOM_SAN_PHAM> DM_NHOM_SAN_PHAM { get; set; }
        public virtual ICollection<DM_PHONG_BAN> DM_PHONG_BAN { get; set; }
        public virtual ICollection<DM_TRANG_THAI> DM_TRANG_THAI { get; set; }
        public virtual ICollection<HT_USER_GROUP> HT_USER_GROUP { get; set; }
    }
}
