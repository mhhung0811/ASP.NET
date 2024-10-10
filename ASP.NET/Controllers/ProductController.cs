using BaiTap4___NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap4___NET.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QUANLYSANPHAMBAI4ConnectionString"].ConnectionString;
            QuanlySanPhamDataContext context = new QuanlySanPhamDataContext(connectionString);
            List<PRODUCT> dsProduct = context.PRODUCTs.ToList();
            return View(dsProduct);
        }
    }
}