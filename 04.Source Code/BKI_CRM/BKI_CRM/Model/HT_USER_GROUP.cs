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
    
    public partial class HT_USER_GROUP
    {
        public HT_USER_GROUP()
        {
            this.HT_PHAN_QUYEN_CHO_NHOM = new HashSet<HT_PHAN_QUYEN_CHO_NHOM>();
            this.HT_USER = new HashSet<HT_USER>();
        }
    
        public System.Guid ID { get; set; }
        public string TEN_NHOM_NGUOI_SU_DUNG { get; set; }
        public string GHI_CHU { get; set; }
        public Nullable<System.Guid> ID_CONG_TY { get; set; }
    
        public virtual DM_CONG_TY DM_CONG_TY { get; set; }
        public virtual ICollection<HT_PHAN_QUYEN_CHO_NHOM> HT_PHAN_QUYEN_CHO_NHOM { get; set; }
        public virtual ICollection<HT_USER> HT_USER { get; set; }
    }
}
