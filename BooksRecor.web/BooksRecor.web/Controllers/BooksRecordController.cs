using BookRecor.Services;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;

namespace BooksRecor.web.Controllers
{
    public class BooksRecordController : Controller
    {
        bookshelfEntities _db = new bookshelfEntities();
        // GET: BooksRecord
        public ActionResult GetBookShelf()
        {
            var booklist = new BooksRepo(_db).GetBookRecord();
            return View(booklist);
        }
        public ActionResult GetBook(string id)
        {
          return  View();
        }
        [HttpGet]
        public ActionResult SaveBook(string id)
        {
           BookRecord Book = new BookRecord();
            if (!string.IsNullOrEmpty(id))
            {
                int i = 0;
                int.TryParse(id , out i);
                Book = new BooksRepo(_db).Getbook(i);
            }
            return View(Book);
        }
      [HttpPost]
        public ActionResult SaveBook(BookRecord br)
        {
            if (ModelState.IsValid)
            {
                var shelf = new BooksRepo(_db).SaveBookInRecord(br);
            ViewBag.Status = "Book Save Successfully!";
            return RedirectToAction("GetBookShelf");
            }
  
            return View(br);
        }
        [HttpGet]
        public ActionResult Update(string id)
        {
            return RedirectToAction("SaveBook", routeValues: new { @id = id });
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            int n = 0;
            int.TryParse(id, out n);
           
            if(n > 0)
            {
                new BooksRepo(_db).RemoveBook(n);
            }
            return RedirectToAction("GetBookShelf");
        }
    }
}