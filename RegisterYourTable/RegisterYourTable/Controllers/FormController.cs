using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TableRegistration.Services;

namespace RegisterYourTable.Controllers
{
    public class FormController : Controller
    {
        BookATableEntities1 _db = new BookATableEntities1();

        #region
        // GET: Form
        //public ActionResult GetForm()
        //{
        //    return View();

        //}
        //public ActionResult DumyForm(int? value)
        //{
        //    List<SelectListItem> items = new List<SelectListItem>();
        //    SelectListItem item1 = new SelectListItem { Text = "AC", Value = "1", Selected = true };
        //    SelectListItem item2 = new SelectListItem { Text = "Non AC", Value = "2", Selected = false };
        //    SelectListItem item3 = new SelectListItem { Text = "Family Budget Pack", Value = "3", Selected = false };
        //    SelectListItem item4 = new SelectListItem { Text = "With Smoking Zone", Value = "4", Selected = false };
        //    SelectListItem item5 = new SelectListItem { Text = "On Terrace", Value = "5", Selected = false };



        //    items.Add(item1);
        //    items.Add(item2);
        //    items.Add(item3);
        //    items.Add(item4);
        //    items.Add(item5);
        //    if(value != null)
        //    {
        //        items.Where(i => i.Value == value.ToString()).First().Selected=true;
        //    }
        //    ViewBag.ServiceList = items;
        //    return View();

        //}
        #endregion


        public ActionResult GetAllBookings()
        {
            var record = new TableRepo(_db).GetAllBookings();
            return View(record);
        }


     [HttpGet]
        public ActionResult SaveFormCollection()
        {
            var dropdownItem = new BookTable();
            dropdownItem.ServiceNameList = new List<AvailService>()
            {
                new AvailService() {ChoosenServices = "Ac"},
                new AvailService() {ChoosenServices = "Non Ac"},
                new AvailService() {ChoosenServices = "Family Budget Pack"},
                new AvailService() {ChoosenServices = "With Smoking Zone"},
                new AvailService() {ChoosenServices = "On Terrace"}
            };
            ViewBag.dropdownItem = dropdownItem;
            BookTable defaultbook = new BookTable()
            {
                ChoosenServices = "Ac",
                tableId = 1
            };
            return View(defaultbook);
        }

       

        [HttpPost]
        public ActionResult SaveFormCollection(FormCollection form)
        {
            var YourName = form["YourName"];
            return View();
        }




        public ActionResult GetOneBooking(string tableId)
        {
            return View();
        }
        [HttpGet]
        public ActionResult SaveForm(string tableId)
        {
           
            BookTable b = new BookTable();
            if (!string.IsNullOrEmpty(tableId))
            {
                int id = 0;
                int.TryParse(tableId, out id);
                b = new TableRepo(_db).GetOneBooking(id);
            }
            return View(b);
        }
        [HttpPost]
        public ActionResult SaveForm(BookTable b)
        {
            if (ModelState.IsValid)
            {
                var fillingNewRow = new TableRepo(_db).SaveFormData(b);
                ViewBag.Status = "Booking Successfully";
                return RedirectToAction("GetAllBookings");
            }
            return View(b);
        }

        //Update
        public ActionResult Update(string tableId)
        {
            return RedirectToAction("SaveForm", new { @tableid = tableId });
        }
        //Delete
        public ActionResult Delete(string tableId)
        {
            if (tableId != null)
            {
                int k = 0;
                int.TryParse(tableId, out k);
                if (k > 0)
                {
                    var result = new TableRepo(_db).RemoveFromRecord(k);
                }
            }
            return RedirectToAction("GetAllBookings");
        }

    }
}