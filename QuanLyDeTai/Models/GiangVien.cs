//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDeTai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GiangVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiangVien()
        {
            this.HuongDans = new HashSet<HuongDan>();
        }
    
        public int MaGV { get; set; }
        public string TenGV { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<int> NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string HocVi { get; set; }
        public Nullable<int> MaKhoa { get; set; }
    
        public virtual Khoa Khoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HuongDan> HuongDans { get; set; }
    }
}
