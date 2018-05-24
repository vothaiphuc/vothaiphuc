using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using 2 thư viện thiết kế class metadata
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebSiteBanSach.Models
{
   [MetadataTypeAttribute(typeof(SachMetadata))]
    public partial class Sach
    {
       internal sealed class SachMetadata
       {

           [Display(Name = "Mã sách")]//Thuộc tính Display dùng để đặt tên lại cho cột
           public int MaSach { get; set; }
           [Display(Name = "Tên sách")]
           [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")] //Kiểm tra rổng
           public string TenSach { get; set; }
           [Display(Name = "Giá bán")]
           public Nullable<decimal> GiaBan { get; set; }
           [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")] 
           [Display(Name = "Mô tả")]
           public string MoTa { get; set; }
           [DataType(DataType.Date)]
           [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]//Định dạng ngày sinh
           [Display(Name = "Ngày cập nhật")]
           [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")] 
           public Nullable<System.DateTime> NgayCapNhat { get; set; }
           [Display(Name = "Ảnh bìa")]
        
           public string AnhBia { get; set; }
           [Display(Name = "Số lượng tồn")]
           [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")] 
           public Nullable<int> SoLuongTon { get; set; }
           [Display(Name = "Chủ đề")]
          
           public Nullable<int> MaChuDe { get; set; }
           [Display(Name = "Nhà xuất bản")]
     
           public Nullable<int> MaNXB { get; set; }
           [Display(Name = "Mới")]
           [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")] 
           public Nullable<int> Moi { get; set; }
       }
    }
}