using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using System.Diagnostics;
using UnifiedPerformanceApplication.Models;

namespace UnifiedPerformanceApplication.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// About Bundling and Minification.
        /// </summary>
        /// <returns>A view consists of bundled and minified CSS and JS files for Bundling and Minification</returns>
        public IActionResult AboutBundlingMinification()
        {
            return View();
        }

        /// <summary>
        /// The response is cached for 5 seconds,the same response will be returned without executing the action again.
        /// </summary>
        /// <returns>A view with a message displaying the Cached time</returns>

        [OutputCache(Duration = 5)]
        public IActionResult CachedAction()
        {
            ViewData["Message"] = "This is a cached response. The time is " + DateTime.Now;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
