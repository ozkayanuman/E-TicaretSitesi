using E_Ticaret_Dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret_WebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();//referans olarak ekledik katmanli mimari de referans olayi cok onemlidir!!
        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Products.Where(i=> i.IsHome && i.IsApproved).ToList());
        }

        public ActionResult ProductList()
        {
            return View(_context.Products.Where(i=>i.IsApproved).ToList());
        }

        public ActionResult ProductDetails(int id)
        {
            return View(_context.Products.Where(i => i.Id==id).ToList());
        }
    }
}