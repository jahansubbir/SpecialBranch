using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SpecialBranch.BLL;
using SpecialBranch.Models;
using SpecialBranch.DbContext;

namespace SpecialBranch.Controllers
{
    public class RPOController : Controller
    {
        private SbDbContext db = new SbDbContext();
        RpoManager rpoManager = new RpoManager();
        // GET: /RPO/
        public ActionResult Index()
        {
            rpoManager.GetRpos();
            return View();
        }

        // GET: /RPO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rpo rpo = rpoManager.Details(id);
            if (rpo == null)
            {
                return HttpNotFound();
            }
            return View(rpo);
        }

        // GET: /RPO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /RPO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Title")] Rpo rpo)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = rpoManager.SaveRpo(rpo);
                return RedirectToAction("Index");
            }

            return View(rpo);
        }

        // GET: /RPO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rpo rpo = rpoManager.Details(id);
            if (rpo == null)
            {
                return HttpNotFound();
            }
            return View(rpo);
        }

        // POST: /RPO/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Title")] Rpo rpo)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = rpoManager.Edit(rpo);
                return RedirectToAction("Index");
            }
            return View(rpo);
        }

        // GET: /RPO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rpo rpo = rpoManager.Details(id);
            if (rpo == null)
            {
                return HttpNotFound();
            }
            return View(rpo);
        }

        // POST: /RPO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rpo rpo = rpoManager.Details(id);
            ViewBag.Message = rpoManager.Delete(rpo);
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
    }
}
