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
    
    public partial class V_GD_NGUOI_QUAN_LY_KHACH_HANG
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_KHACH_HANG { get; set; }
        public System.Guid ID_NGUOI_SU_DUNG { get; set; }
        public Nullable<System.Guid> ID_QUYEN_QUAN_LY { get; set; }
        public bool ACTIVE_YN { get; set; }
        public string HO_TEN_NHAN_VIEN { get; set; }
        public System.Guid ID_USER { get; set; }
        public string TEN_TU_DIEN { get; set; }
    }
}