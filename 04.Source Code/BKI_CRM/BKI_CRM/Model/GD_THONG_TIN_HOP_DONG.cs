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
    
    public partial class GD_THONG_TIN_HOP_DONG
    {
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> NGAY_BAT_DAU { get; set; }
        public Nullable<System.DateTime> NGAY_KET_THUC { get; set; }
        public decimal SO_HOP_DONG { get; set; }
        public string NOI_DUNG { get; set; }
        public string GHI_CHU_1 { get; set; }
        public string GHI_CHU_2 { get; set; }
        public string GHI_CHU_3 { get; set; }
        public System.Guid ID_GD_KHACH_HANG_SU_DUNG_SAN_PHAM { get; set; }
    
        public virtual GD_KHACH_HANG_SU_DUNG_SAN_PHAM GD_KHACH_HANG_SU_DUNG_SAN_PHAM { get; set; }
    }
}