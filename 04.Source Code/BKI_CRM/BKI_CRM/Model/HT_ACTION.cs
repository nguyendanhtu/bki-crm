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
    
    public partial class HT_ACTION
    {
        public HT_ACTION()
        {
            this.HT_PHAN_QUYEN_CHO_NHOM = new HashSet<HT_PHAN_QUYEN_CHO_NHOM>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid ID_CONTROLLER { get; set; }
        public string ACTION_NAME { get; set; }
        public string TEST { get; set; }
    
        public virtual HT_CONTROLLER HT_CONTROLLER { get; set; }
        public virtual ICollection<HT_PHAN_QUYEN_CHO_NHOM> HT_PHAN_QUYEN_CHO_NHOM { get; set; }
    }
}
