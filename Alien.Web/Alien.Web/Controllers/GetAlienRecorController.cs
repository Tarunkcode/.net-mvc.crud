using Alien.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alien.Web.Controllers
{
    public class GetAlienRecorController : Controller
    {
        AlienEntities _db = new AlienEntities();
        // GET: GetAlienRecor
        public ActionResult GetAllAlienRecord()
        {
            var record = new alienRepo(_db).GetAllAlientRecord();
            return View(record);
        }
        public ActionResult GetOneRecord(string id)
        {

            return View();
        }
        [HttpGet]
        public ActionResult SaveAlienRecord(string id)
        {
            alien Alien = new alien();
            if(!string.IsNullOrEmpty(id))
            {
                int k = 0;
                int.TryParse(id,out k);
                Alien = new alienRepo(_db).GetOneRecord(k);

            }

            return View(Alien);
        }
        [HttpPost]
        public ActionResult SaveAlienRecord(alien a)
        {
            if (ModelState.IsValid)
            {
            var fillingNewAlienData = new alienRepo(_db).SaveAlienRecord(a);
                ViewBag.Status = "Alien Signature Scan Successfully";
                return RedirectToAction("GetAllAlienRecord");

            }
            return View(a);
        }
        //update
        [HttpGet]
        public ActionResult Update(string id)
        {
            return RedirectToAction("SaveAlienRecord", new { @id = id });
        }
        //Delete
        public ActionResult Delete(string id)
        {
            if(id != null)
            {
                int k = 0;
                int.TryParse(id, out k);
                if(k > 0)
                {
                    var result = new alienRepo(_db).RemoveFromRecord(k);
                }
            }
            return RedirectToAction("GetAllAlienRecord");
        }
    }
}