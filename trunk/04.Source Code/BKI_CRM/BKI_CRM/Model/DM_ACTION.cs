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
    
    public partial class DM_ACTION
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_CONG_TY { get; set; }
        public System.Guid ID_LOAI_ACTION { get; set; }
        public string MA_ACTION { get; set; }
        public string TEN_ACTION { get; set; }
        public string GHI_CHU_1 { get; set; }
        public string GHI_CHU_2 { get; set; }
        public string GHI_CHU_3 { get; set; }
    
        public virtual CM_DM_TU_DIEN CM_DM_TU_DIEN { get; set; }
        public virtual DM_CONG_TY DM_CONG_TY { get; set; }
    }
}
