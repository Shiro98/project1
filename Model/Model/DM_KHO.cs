//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_KHO
    {
        public int ID_KHO { get; set; }
        public string PHIEN_HIEU_KHO { get; set; }
        public string TEN_KHO { get; set; }
        public string MO_TA { get; set; }
        public string DIA_CHI { get; set; }
        public Nullable<int> KHU_VUC_ID { get; set; }
        public Nullable<int> DON_VI_ID { get; set; }
        public Nullable<System.Guid> KHO_CHA_ID { get; set; }
        public string IS_HOP_DONG { get; set; }
        public Nullable<long> HOP_DONG_ID { get; set; }
        public Nullable<int> CONG_TY_ID { get; set; }
        public Nullable<int> STATUS { get; set; }
        public System.DateTime NGAY_TAO { get; set; }
        public Nullable<System.DateTime> NGAY_CAP_NHAT { get; set; }
        public Nullable<int> NGUOI_CAP_NHAT { get; set; }
    }
}
