using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BontoBuyWebApplication.Models;
using BontoBuyWebApplication.Models.UserRole;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNet.Identity;

namespace BontoBuyWebApplication.Controllers
{
    
    public class AdminSupplierController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AdminSupplier
        public ActionResult Index()
        {

            //string userId = User.Identity.GetUserId();
            //User currentUser = db.Users.FirstOrDefault(x => x.Id == userId);
            //return Content(userId);

            return View(db.Suppliers.ToList());
            //IQueryable<Supplier> supplierQuery =
            //   from supplier in db.Suppliers
            //   where supplier.Email == "kchungsemchong@gmail.com"
            //   select supplier;
           // return View(supplierQuery);
        }

        // GET: AdminSupplier/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Supplier supplier = db.Suppliers.Find(id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            return View(supplier);
        }


        // GET: AdminSupplier/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Supplier supplier = db.Suppliers.Find(id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            return View(supplier);
        }

        // POST: AdminSupplier/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        [DataType(DataType.Date)]
        public ActionResult EditPost(string id)
        {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var supplierToUpdate = db.Suppliers.Find(id);
                if(TryUpdateModel(supplierToUpdate,"",
                    new string[]{"SupplierName","Status"}))
                {
                    try
                    {
                        Supplier supplier = (from p in db.Suppliers
                                             where p.Id == id
                                             select p).SingleOrDefault();
                        supplier.DateUpdated = DateTime.UtcNow;
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    catch (DataException)
                    {
                        ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                    }

                }
                //db.Entry(supplier).State = EntityState.Modified;
                //supplier.DateUpdated = DateTime.UtcNow;
                //db.SaveChanges();
                //return RedirectToAction("Index");
          
            return View(supplierToUpdate);
        }

        // GET: AdminSupplier/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Supplier supplier = db.Suppliers.Find(id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            return View(supplier);
        }

        // POST: AdminSupplier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Supplier supplier = db.Suppliers.Find(id);
            db.Suppliers.Remove(supplier);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Dashboard()
        {
            return View();
        }
    }
}
