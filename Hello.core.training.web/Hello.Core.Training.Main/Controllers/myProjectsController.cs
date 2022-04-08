using Hello.core.training.Services.ContextDataModel;
using Hello.core.training.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello.Core.Training.Main.Controllers
{
    [Route("api/[controller]/[action]")]
    public class myProjectsController : Controller
    {
        private readonly ILogger<myProjectsController> _logger;
        private readonly CoreTrainingDemoBaseContext _db;
        public myProjectsController(ILogger<myProjectsController> logger, CoreTrainingDemoBaseContext db)

        {
            _logger = logger;
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var result = await new Repository(_db).getAll();
            return Ok(result);
        }


        [HttpPost]
        public async Task< ActionResult> SaveProject([FromBody] CoreTable coretable)
        {
            bool result = false;
            if (ModelState.IsValid)
            {
               result = await new Repository(_db).SaveProject(coretable);
            }
            return Ok(coretable);
        }
     
    }
}
