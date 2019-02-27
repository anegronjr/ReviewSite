﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewSite.Repositories;

namespace ReviewSite.Controllers
{
    public class CategoryController : Controller
    {
        
        CategoryRepository repo;
        ReviewController controller;
        public CategoryController(CategoryRepository repo, ReviewController controller)
        {
            this.repo = repo;
            this.controller = controller;
        }

        public ViewResult Index()
        {
            var model = repo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = repo.GetById(id);
            return View(model);
        }

        public void Review(int id)
        {
            controller.Details(id);
        }
    }
}