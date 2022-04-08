using Excellent.Training.Service;
using System.Web.Mvc;

namespace Excellent.training.web.Controllers
{
    public class PlayerController : Controller
    {
        KKTrainingEntities1 _db = new KKTrainingEntities1();
        public ActionResult GetAllPlayerRecord()
        {
            var recordlist = new Repository(_db).GetPlayers();
          
            return View(recordlist);
        }
       
        public ActionResult GetPlayerRecord(string rnk)
        {
            return View();
        }
        [HttpGet]
        public ActionResult SavePlayerRecord(string PlayerRank) // controller method args passed from view
        {

            PlayerRecord Player = new PlayerRecord();
            if (!string.IsNullOrEmpty(PlayerRank))
            {
                int r = 0;
                int.TryParse(PlayerRank, out r);
                Player = new Repository(_db).GetPlayer(r);
            }
            return View(Player);
        }
        [HttpPost]
        public ActionResult SavePlayerRecord(PlayerRecord pr)
        {
            if (ModelState.IsValid)
            {
                var result = new Repository(_db).SavePlayerRecord(pr);
                ViewBag.Status = "Data Insert Sucessfully.";
                return RedirectToAction("GetAllPlayerRecord");

            }

            return View(pr);
        }
        [HttpGet]
        public ActionResult Update(string PlayerRank)
        {
            return RedirectToAction("SavePlayerRecord", routeValues: new { @PlayerRank = PlayerRank });

        }

        [HttpGet]
        public ActionResult Delete(string PlayerRank)
        {
            int Rank = 0;
            int.TryParse(PlayerRank, out Rank);
            if (Rank > 0)
            {
                new Repository(_db).DeleteEmployee(Rank);
            }

            return RedirectToAction("GetAllPlayerRecord");
        }
    }
}