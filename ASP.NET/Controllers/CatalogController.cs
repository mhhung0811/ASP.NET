using BaiTap4___NET.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap4___NET.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            // get connectionString from web.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QUANLYSANPHAMBAI4ConnectionString"].ConnectionString;
            QuanlySanPhamDataContext context = new QuanlySanPhamDataContext(connectionString);
            List<CATALOG> dsCatalog = context.CATALOGs.ToList();
            //debug data
            for (int i = 0; i < dsCatalog.Count; i++)
            {
                Debug.WriteLine(dsCatalog[i].CATALOGCODE);
            }
            return View(dsCatalog);
        }
    }
}