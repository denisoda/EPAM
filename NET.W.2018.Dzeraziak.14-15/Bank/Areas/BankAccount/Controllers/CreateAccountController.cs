using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace Bank.Areas.BankAccount
{
    public class CreateAccountController : Controller
    {
        BankRepository rep = new BankRepository();

        [HttpGet]
        public ActionResult Index()
        {
            return View(new AccountModel());
        }

        // POST: BankAccount/CreateAccount
        [HttpPost]
        public ActionResult Index(AccountModel account)
        {
            try
            {
                rep.AddCustomer(account);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankAccount/CreateAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankAccount/CreateAccount/Edit/5
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

        // GET: BankAccount/CreateAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankAccount/CreateAccount/Delete/5
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