//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBanHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class congnghe
    {
        public congnghe()
        {
            this.sanpham = new HashSet<sanpham>();
        }
    
        public int macn { get; set; }
        public string loaicn { get; set; }
    
        public virtual ICollection<sanpham> sanpham { get; set; }
    }
}
