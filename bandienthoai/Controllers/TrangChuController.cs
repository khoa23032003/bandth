using bandienthoai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bandienthoai.Controllers
{
    public class TrangChuController : Controller
    {
        QLBANSACHEntities db = new QLBANSACHEntities();
        // GET: TrangChu
        public ActionResult Index()
        {
            return View();
        }
        //lay so luong sach 
        public List<SACH> LaySach(int id)
        {
            return db.SACHes.OrderByDescending(s=>s.Ngaycapnhat).Take(id).ToList();
        }
        public ActionResult HienThi(){
        var sl = LaySach(5);
            return View(sl);
            
        }
        public ActionResult Chitietsp()
        {
            return View();
        }

    }
}