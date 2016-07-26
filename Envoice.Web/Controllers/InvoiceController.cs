using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Envoice.Web.Models.InvoiceViewModels;

namespace Envoice.Web.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult New()
        {
            var viewModel = new InvoiceViewModel();

            viewModel.InvoiceNumber = "12345";
            viewModel.InvoiceDate = DateTime.Now;

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(InvoiceViewModel viewModel)
        {
            

            return View("New");
        }
    }
}
