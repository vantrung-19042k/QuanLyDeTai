using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PagedList;
using QuanLyDeTai.Models;
using System.Web;

namespace QuanLyDeTai.Controllers
{
    public class QuanLySinhVienController : Controller
    {
        QLDTEntities db = new QLDTEntities();

        // GET: QuanLySinhVien
        public ActionResult Index(int? page)
        {
            IEnumerable<SinhVien> lstSV = db.SinhViens;

            if (Request.HttpMethod != "GET")
            {
                page = 1;
            }

            //thực hiện chức năng phân trang
            //1.tạo biến số sản phẩm trên trang
            int PageSize = 5;

            //2.tạo biến số trang hiện tại
            int PageNumber = (page ?? 1);

            return View(lstSV.OrderBy(n => n.MaSV).ToPagedList(PageNumber, PageSize));
        }

        #region thêm sinh viên
        public ActionResult ThemSinhVien()
        {
            ViewBag.LstLop = new SelectList(db.Lops.OrderBy(n => n.MaLop), "MaLop", "TenLop");

            return View();
        }

        [HttpPost]
        public ActionResult ThemSinhVien(SinhVien sv)
        {
            ViewBag.LstLop = new SelectList(db.Lops.OrderBy(n => n.MaLop), "MaLop", "TenLop");

            try
            {
                db.SinhViens.Add(sv);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region sửa sinh viên
        public ActionResult SuaSinhVien(int? id)
        {
            ViewBag.LstLop = new SelectList(db.Lops.OrderBy(n => n.MaLop), "MaLop", "TenLop");

            //Lấy thông tin sinh viên cần chỉnh sửa dựa vào id
            if (id == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            SinhVien sv = db.SinhViens.SingleOrDefault(n => n.MaSV == id);

            if (sv == null)
            {
                return HttpNotFound();
            }

            return View(sv);
        }

        [HttpPost]
        public ActionResult SuaSinhVien(SinhVien sv)
        {
            ViewBag.LstLop = new SelectList(db.Lops.OrderBy(n => n.MaLop), "MaLop", "TenLop");

            try
            {
                db.Entry(sv).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return RedirectToAction("Index");
        }

        #endregion

        #region Xóa sinh viên
        public ActionResult XoaSinhVien(int? id)
        {
            SinhVien sv = db.SinhViens.SingleOrDefault(n => n.MaSV == id);

            //try
            //{
            //    db.SinhViens.Remove(sv);
            //    db.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            return View(sv);
        }
        #endregion


        #region giải phóng biến cho vùng nhớ
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                    db.Dispose();
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}