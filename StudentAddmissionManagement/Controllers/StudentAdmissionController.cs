using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAddmissionManagement.Controllers
{
    public class StudentAdmissionController : Controller
    {
        // GET: StudentAdmissionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentAdmissionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentAdmissionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentAdmissionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentAdmissionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentAdmissionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentAdmissionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentAdmissionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
