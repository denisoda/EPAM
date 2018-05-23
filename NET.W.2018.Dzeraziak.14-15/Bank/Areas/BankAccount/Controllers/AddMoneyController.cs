using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank.Areas.BankAccount.Controllers
{
    public class AddMoneyController : Controller
    {
        // GET: BankAccount/AddMoney
        public ActionResult Index()
        {
            return View();
        }

        // GET: BankAccount/AddMoney/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BankAccount/AddMoney/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankAccount/AddMoney/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankAccount/AddMoney/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankAccount/AddMoney/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankAccount/AddMoney/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankAccount/AddMoney/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
