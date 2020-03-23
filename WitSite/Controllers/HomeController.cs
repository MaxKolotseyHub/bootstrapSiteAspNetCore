using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WitSite.Helpers;
using WitSite.Interfaces;
using WitSite.Models;

namespace WitSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMailSender<ClientInfo> mailSender;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            mailSender = new MailSender();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public void SendMail([FromBody]ClientInfo client)
        {
            //mailSender.SendMail(client);
            //return RedirectToAction("Index");
        }
    }
}
    