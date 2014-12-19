using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VQStore.Filters;
using VQStore.Models;
using WebMatrix.WebData;

namespace VQStore.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
    public class SubmissionsController : Controller
    {
        //
        // GET: /Submissions/

        public ActionResult Index()
        {
            int id = WebSecurity.CurrentUserId;
            List<VQProject> submissions = null;
            using (UsersContext context = new UsersContext())
            {
                VQProfile profile = context.Set<VQProfile>().FirstOrDefault(p => p.profile.UserId == id);
                submissions = profile.submissions;

            }
            
            return View(submissions);
        }

        //
        // GET: /Submissions/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Submissions/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Submissions/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Submissions/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Submissions/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Submissions/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Submissions/Delete/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
