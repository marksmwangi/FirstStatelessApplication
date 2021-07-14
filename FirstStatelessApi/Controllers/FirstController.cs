using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstStatelessApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstController : Controller
    {

        [HttpGet]
        [Route("[get1]")]
        public async Task Get()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        // GET: FirstController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FirstController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FirstController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FirstController/Create
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

        // GET: FirstController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FirstController/Edit/5
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

        // GET: FirstController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FirstController/Delete/5
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
