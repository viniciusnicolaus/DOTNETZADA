using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistencia;

namespace Fiap05.Web.MVC.Controllers
{
    public class CartaoRealsController : Controller
    {
        private FiapBankContext db = new FiapBankContext();

        // GET: CartaoReals
        public ActionResult Index()
        {
            return View(db.CartoesReais.ToList());
        }

        // GET: CartaoReals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartaoReal cartaoReal = db.CartoesReais.Find(id);
            if (cartaoReal == null)
            {
                return HttpNotFound();
            }
            return View(cartaoReal);
        }

        // GET: CartaoReals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartaoReals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CartaoRealId,Numero,Cvv,Status")] CartaoReal cartaoReal)
        {
            if (ModelState.IsValid)
            {
                db.CartoesReais.Add(cartaoReal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cartaoReal);
        }

        // GET: CartaoReals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartaoReal cartaoReal = db.CartoesReais.Find(id);
            if (cartaoReal == null)
            {
                return HttpNotFound();
            }
            return View(cartaoReal);
        }

        // POST: CartaoReals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CartaoRealId,Numero,Cvv,Status")] CartaoReal cartaoReal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cartaoReal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cartaoReal);
        }

        // GET: CartaoReals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartaoReal cartaoReal = db.CartoesReais.Find(id);
            if (cartaoReal == null)
            {
                return HttpNotFound();
            }
            return View(cartaoReal);
        }

        // POST: CartaoReals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CartaoReal cartaoReal = db.CartoesReais.Find(id);
            db.CartoesReais.Remove(cartaoReal);
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
    }
}
