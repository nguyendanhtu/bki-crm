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
    
    public partial class GD_CHUYEN_TRANG_THAI
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_TRANG_THAI { get; set; }
        public Nullable<System.Guid> ID_NGUOI_CHUYEN_TRANG_THAI { get; set; }
        public Nullable<decimal> SO_TIEN_DA_NHAN { get; set; }
        public System.DateTime NGAY_CHUYEN_TRANG_THAI { get; set; }
        public bool DANG_CHAM_SOC_YN { get; set; }
        public bool TRANG_THAI_HIEN_TAI_YN { get; set; }
        public string GHI_CHU { get; set; }
        public string KIEM_TRA_YEU_CAU_CHUYEN_TRANG_THAI { get; set; }
        public Nullable<System.Guid> ID_KHACH_HANG { get; set; }
    
        public virtual DM_KHACH_HANG DM_KHACH_HANG { get; set; }
        public virtual DM_TRANG_THAI DM_TRANG_THAI { get; set; }
        public virtual HT_USER HT_USER { get; set; }
    }
}
