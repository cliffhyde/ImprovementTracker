using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Web.Mvc;
using TelerikImprovements.DAL;

namespace TelerikImprovements.Controllers
{
    public partial class ImprovementController : Controller
    {
        private ImprovementTrackerEntities db = new ImprovementTrackerEntities();
        // GET: Improvement
        public ActionResult Index()
        {
            var model = db.Improvements.ToList();
            return View(model);
        }

  
        //public ActionResult Local_Data_Binding()
        //{
        //    var model = db.Improvements.ToList();

        //    return View("index",model);
        //}       


    }
}