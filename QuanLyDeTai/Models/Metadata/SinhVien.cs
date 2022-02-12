using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace QuanLyDeTai.Models
{
    [MetadataType(typeof(SinhVienMetadata))]
    public partial class SinhVien
    {
        internal sealed class SinhVienMetadata
        {
            //Danh sách các thuộc tính

            [Display(Name = "Mã sinh viên")]
            public int MaSV { get; set; }

            [Display(Name = "Tên sinh viên")]
            public string TenSV { get; set; }

            [Display(Name = "Giới tính")]
            public string GioiTinh { get; set; }

            [Display(Name = "Năm sinh")]
            public Nullable<int> NamSinh { get; set; }

            [Display(Name = "Quê quán")]
            public string QueQuan { get; set; }

            [Display(Name = "Địa chỉ")]
            public string DiaChi { get; set; }

            [Display(Name = "Email")]
            public string Email { get; set; }

            [Display(Name = "SĐT")]
            public string SDT { get; set; }

            [Display(Name = "Mã lớp")]
            public Nullable<int> MaLop { get; set; }

            [Display(Name = "Mã đề tài")]
            public Nullable<int> MaDeTai { get; set; }
        }
    }
}