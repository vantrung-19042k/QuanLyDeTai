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
    
    public partial class SinhVien
    {
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<int> NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public Nullable<int> MaLop { get; set; }
        public Nullable<int> MaDeTai { get; set; }
    
        public virtual DeTai DeTai { get; set; }
        public virtual Lop Lop { get; set; }
    }
}