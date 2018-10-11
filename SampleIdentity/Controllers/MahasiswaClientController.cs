using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleIdentity.Services;

namespace SampleIdentity.Controllers
{
    public class MahasiswaClientController : Controller
    {
        private IMahasiswaService _mhsservice;
        public MahasiswaClientController(IMahasiswaService mhsservice)
        {
            _mhsservice = mhsservice;
        }

        // GET: MahasiswaClient
        public ActionResult Index()
        {
            var models = _mhsservice.GetAll();
            return View(models);
        }

        // GET: MahasiswaClient/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MahasiswaClient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MahasiswaClient/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MahasiswaClient/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MahasiswaClient/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MahasiswaClient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MahasiswaClient/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}