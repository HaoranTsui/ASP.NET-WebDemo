using Indutry4._0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using AspNetUserRolesEntityFramework.Data;
using Microsoft.EntityFrameworkCore;
using Indutry4._0.Data;

namespace Indutry4._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        //public IActionResult CompaniesOrganizations()
        //{
        //    return View();
        //}

        public async Task<IActionResult> CompaniesOrganizations()
        {
            if (!User.Identity.IsAuthenticated)
            {
                foreach (var post in _context.FeedbackPost)
                {
                    post.CanIncreaseAgree = true;
                    post.CanIncreaseDisagree = true;
                }
                await _context.SaveChangesAsync();
            }

            var allFeedbakPosts = from result in _context.FeedbackPost
                                 orderby result.Date descending
                                 select result;

            return View(await allFeedbakPosts.ToListAsync());

            //return View(await _context.FeedbackPost.ToListAsync());
        }


        public async Task<IActionResult> EmergingTechnologiesAsync()
        {
            var allFeedbakPosts = from result in _context.FeedbackPost
                                  orderby result.Date descending
                                  select result;

            return View(await allFeedbakPosts.ToListAsync());
        }

        public IActionResult ContactAbout()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
