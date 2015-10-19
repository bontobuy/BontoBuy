using BontoBuyWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BontoBuyWebApplication.Controllers
{
   
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (var _db = new ApplicationDbContext())
            {
                var model = _db.Suppliers.ToList();
                return View(model);
             
            }
            
        }
    }
}