using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Coin.Data;
using Coin.Models;

namespace Coin.Controllers
{
    public class CoinListsController : Controller
    {
        private MyDBContext db = new MyDBContext();

        // GET: CoinLists
        public ActionResult Index()
        {
            return View(db.CoinLists.ToList());
        }

        // GET: CoinLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoinList coinList = db.CoinLists.Find(id);
            if (coinList == null)
            {
                return HttpNotFound();
            }
            return View(coinList);
        }

        // GET: CoinLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoinLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,BaseAsset,QouteAsset,LastPrice,Volumn24h,MarketId,CreatedAt,UpdatedAt,Status")] CoinList coinList)
        {
            if (ModelState.IsValid)
            {
                db.CoinLists.Add(coinList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coinList);
        }

        // GET: CoinLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoinList coinList = db.CoinLists.Find(id);
            if (coinList == null)
            {
                return HttpNotFound();
            }
            return View(coinList);
        }

        // POST: CoinLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,BaseAsset,QouteAsset,LastPrice,Volumn24h,MarketId,CreatedAt,UpdatedAt,Status")] CoinList coinList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coinList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coinList);
        }

        // GET: CoinLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoinList coinList = db.CoinLists.Find(id);
            if (coinList == null)
            {
                return HttpNotFound();
            }
            return View(coinList);
        }

        // POST: CoinLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CoinList coinList = db.CoinLists.Find(id);
            db.CoinLists.Remove(coinList);
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
