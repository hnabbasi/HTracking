using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var forms = _apiService.GetForms();
            return View();
        }
    }
}
