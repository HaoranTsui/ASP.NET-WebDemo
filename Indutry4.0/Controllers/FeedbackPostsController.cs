using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Indutry4._0.Data;
using Indutry4._0.Models;
using Microsoft.AspNetCore.Authorization;

namespace Indutry4._0.Controllers
{
    public class FeedbackPostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FeedbackPostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FeedbackPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.FeedbackPost.ToListAsync());
        }

        // GET: FeedbackPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackPost = await _context.FeedbackPost
                .FirstOrDefaultAsync(m => m.Id == id);
            if (feedbackPost == null)
            {
                return NotFound();
            }

            return View(feedbackPost);
        }

        // GET: FeedbackPosts/Create
        [Authorize(Roles = "Manager, RegisteredUser")]
        public IActionResult Create()
        {
            FeedbackPost fd = new FeedbackPost();
            fd.Date = DateTime.Now;
            fd.UserName = User.Identity.Name;

            return View(fd);
        }

        // POST: FeedbackPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager, RegisteredUser")]
        public async Task<IActionResult> Create([Bind("Id,Date,UserName,Heading,StarRating,Feedback,Agree,Disagree,CompanyOrganizationName,canIncreaseAgree,canIncreaseDisagree")] FeedbackPost feedbackPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedbackPost);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("companiesOrganizations", "Home");
            }
            return View(feedbackPost);
        }

        // GET: FeedbackPosts/Edit/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackPost = await _context.FeedbackPost.FindAsync(id);
            if (feedbackPost == null)
            {
                return NotFound();
            }
            return View(feedbackPost);
        }

        // POST: FeedbackPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,UserName,Heading,StarRating,Feedback,Agree,Disagree,CompanyOrganizationName,canIncreaseAgree,canIncreaseDisagree")] FeedbackPost feedbackPost)
        {
            if (id != feedbackPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feedbackPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackPostExists(feedbackPost.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("companiesOrganizations", "Home");
            }
            return View(feedbackPost);
        }

        // GET: FeedbackPosts/Delete/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackPost = await _context.FeedbackPost
                .FirstOrDefaultAsync(m => m.Id == id);
            if (feedbackPost == null)
            {
                return NotFound();
            }

            return View(feedbackPost);
        }

        // POST: FeedbackPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var feedbackPost = await _context.FeedbackPost.FindAsync(id);
            _context.FeedbackPost.Remove(feedbackPost);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            return RedirectToAction("companiesOrganizations", "Home");
        }

        private bool FeedbackPostExists(int id)
        {
            return _context.FeedbackPost.Any(e => e.Id == id);
        }

        public async Task<IActionResult> IncreaseAgree(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackPost = await _context.FeedbackPost.FindAsync(id);
            if (feedbackPost == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                //try
                //{
                //    feedbackPost.Agree++;

                //    _context.Update(feedbackPost);
                //    await _context.SaveChangesAsync();
                //}
                try
                {
                    if(User.Identity.IsAuthenticated && feedbackPost.CanIncreaseAgree)
                    {
                        feedbackPost.Agree++;
                        feedbackPost.CanIncreaseAgree = false;
                        _context.Update(feedbackPost);
                        await _context.SaveChangesAsync();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackPostExists(feedbackPost.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("companiesOrganizations", "Home");
                //return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("companiesOrganizations", "Home");
            //return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> IncreaseDisagree(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedbackPost = await _context.FeedbackPost.FindAsync(id);
            if (feedbackPost == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                //try
                //{
                //    feedbackPost.Disagree++;

                //    _context.Update(feedbackPost);
                //    await _context.SaveChangesAsync();
                //}
                try
                {
                    if (User.Identity.IsAuthenticated && feedbackPost.CanIncreaseDisagree)
                    {
                        feedbackPost.Disagree++;
                        feedbackPost.CanIncreaseDisagree = false;
                        _context.Update(feedbackPost);
                        await _context.SaveChangesAsync();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackPostExists(feedbackPost.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("companiesOrganizations", "Home");
                //return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("companiesOrganizations", "Home");
            //return RedirectToAction(nameof(Index));
        }

    }
    
}
