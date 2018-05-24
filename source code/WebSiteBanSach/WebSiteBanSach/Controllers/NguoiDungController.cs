using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanSach.Models;

namespace WebSiteBanSach.Controllers
{
    public class NguoiDungController : Controller
    {

        QuanLyBanSachEntities db = new QuanLyBanSachEntities();
        // GET: /NguoiDung/
        /*public ActionResult Index()
        {
            return View();
        }*/
        [HttpGet]
        public ActionResult DangKy()
        {

            return View();
        }
       /* [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult DangKy(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                //Chèn dữ liệu vào bảng khách hàng
                db.KhachHangs.Add(kh);
                //Lưu vào csdl 
                db.SaveChanges();
            }
            return View();
        }*/
        [HttpPost]
        public ActionResult DangKy(FormCollection f,KhachHang kh)
        {
            //ViewBag.bao = "";
            string hoten = f["txtHoTen"];
            DateTime ngaysinh = DateTime.Parse(f["NgaySinh"]); 
            string gioitinh = f["checkbox"];
            string dienthoai = f["txtDienThoai"];
            string tk = f["txtTaiKhoan"];
            string mk = f["MatKhau"];
            string xnmk = f["XacNhanMatKhau"];
            string email = f["txtEmail"];
            string diachi = f["txtDiaChi"];
            if(tk==""||mk==""||xnmk==""||email==""||diachi==""||hoten==""||dienthoai=="")
            {
                ViewBag.bao = "Dữ liệu nhập vào không được rỗng";
                return View();
            }
            //    else if(mk!=xnmk)
            //{

            //}
            else
            {
                kh.HoTen = hoten;
                kh.DienThoai = dienthoai;
                kh.GioiTinh = gioitinh;
                kh.TaiKhoan = tk;
                kh.MatKhau = mk;
                kh.Email = email;
                kh.DiaChi = diachi;
                kh.NgaySinh = ngaysinh;
                db.KhachHangs.Add(kh);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
               
            }
            
        }
        [HttpGet]
        public ActionResult DangNhap()
        {

            return View();
        }
        public ActionResult DangXuat()
        {
            Session["GioHang"] = null;
            Session["TaiKhoan"] = null;
            return RedirectToAction("DangNhap", "NguoiDung");
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            
            string sTaiKhoan = f["txtTaiKhoan"].ToString();
            string sMatKhau = f.Get("txtMatKhau").ToString();
            KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.TaiKhoan == sTaiKhoan && n.MatKhau == sMatKhau);
            if(sTaiKhoan=="admin" && sMatKhau=="123456")
            {
                return RedirectToAction("Index", "QuanLySanPham");
            }
            if (sTaiKhoan == "" || sMatKhau == "")
            {
                ViewBag.bao = "Tài khoản và Mật khẩu không được để trống !";
                return View();
            }
                
            else if (kh == null)
            {
                ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng!";
                return View();
            }
            else
            {
                if (Session["GioHang"] == null)
                {
                    Session["TaiKhoan"] = kh;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Session["TaiKhoan"] = kh;
                    return RedirectToAction("GioHang", "GioHang");
                }
                
            }
           
            
        }
	}
}