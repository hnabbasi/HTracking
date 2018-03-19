using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTracking.Models;
using HTracking.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTracking.Controllers
{
    public class FormsController : Controller
    {
        readonly IApiService _apiService;

        public FormsController(IApiService apiService)
        {
            _apiService = apiService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var forms = _apiService.GetForms<BaseForm>();
            return View(forms);
        }

        [HttpGet("new-site")]
        public IActionResult NewSiteForm()
        {
            return View();
        }

        [HttpPost("new-site")]
        public IActionResult NewSiteForm(SiteForm model)
        {
            _apiService.SubmitForm(model);
            return Index();// View();
        }

        [HttpGet("new-inventory")]
        public IActionResult NewInventoryForm()
        {
            return View();
        }

        [HttpPost("new-inventory")]
        public IActionResult NewInventoryForm(InventoryForm model)
        {
            _apiService.SubmitForm(model);
            return Index();// View();
        }
    }
}
