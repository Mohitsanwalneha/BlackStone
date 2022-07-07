using Assignment2.Asp.net_Core_L1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace Assignment2.Asp.net_Core_L1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? page)
        {
            

            Items i = new Items();
            List<Items> item = i.AddItems();
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(item.ToPagedList(pageNumber,pageSize));
        }
    }
}