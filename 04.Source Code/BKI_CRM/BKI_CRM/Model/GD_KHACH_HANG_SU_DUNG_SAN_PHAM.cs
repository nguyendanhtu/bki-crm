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
        public System.Guid ID { get; set; }
        public System.Guid ID_KHACH_HANG { get; set; }
        public Nullable<System.Guid> ID_SAN_PHAM { get; set; }
        public string TEN_SAN_PHAM { get; set; }
    
        public virtual DM_SAN_PHAM DM_SAN_PHAM { get; set; }
        public virtual DM_KHACH_HANG DM_KHACH_HANG { get; set; }
    }
}