using System.Collections.Generic;
using System.Linq;
using Dynamic_User_Defined_Dashboards.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DynamicForm.Controllers
{
    public class DashboardController : Controller
    {
        private Dashboard_FormContext db = new Dashboard_FormContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TemplateList(){
            return View("Templates/TemplateList");
        }

        public IActionResult FormList()
        {
            return View("Templates/FormList");
        }

        public string Createdashboard(DashboardsInfo dashboard)
        {
            try
            {
                db.DashboardsInfo.Add(dashboard);
                db.SaveChanges();

                return dashboard.Id.ToString();
            }
            catch (System.Exception)
            {
                return "False";
            }
        }

        public string SaveFormData(SavedFormsList formdataval)
        {
            try
                {
            db.SavedFormsList.Add(formdataval);
            db.SaveChanges();

            return formdataval.Id.ToString();
        }
            catch (System.Exception)
                { 
                return "False";
                }
        }

      

        public ActionResult GetFormsList()
        {
            return Ok(db.SavedFormsList.ToList());
        }


        public IActionResult DisplayForm(int id)
        {
           
            SavedFormsList dashboard = db.SavedFormsList.Where(s => s.Id == id).FirstOrDefault();
          
            ViewData["formdata"] = dashboard.FormData;
            ViewData["createddate"] = dashboard.CreatedData;
            return View("Templates/FormList");
        }
    }
}
