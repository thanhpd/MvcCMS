using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCMS.Models;

namespace MvcCMS.Areas.Admin.Controllers
{
    /* ADMIN DASHBOARD */
    [RouteArea("Admin")]
    [RoutePrefix("post")]
    public class PostController : Controller
    {
        // GET: Admin/Post
        public ActionResult Index()
        {
            return View();
        }

        // GET: admin/post/create
        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            var model = new Post();

            return View(model);
        }

        // POST: admin/post/create
        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: update model in data store

            return RedirectToAction("Index");
        }

        // GET: Admin/post/edit/post-to-edit
        [Route("edit/{id}")]
        public ActionResult Edit(string id)
        {
            // TODO: to retrieve the model from the data store
            var model = new Post();

            return View(model);

        }

        // POST: Admin/post/edit/post-to-edit
        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: update model in data store

            return RedirectToAction("Index");
        }
    }
}