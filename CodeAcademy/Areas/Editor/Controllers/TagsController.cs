﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Areas.Editor.Models.ViewModels;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Areas.Editor.Controllers
{
    [Authorize(Roles = "Editor")]
    [Area("Editor")]
    public class TagsController : Controller
    {
        AppDbContext _dbContext;

        public TagsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var allTags = _dbContext.Tags
                                        .Select(x=> new TagViewModel() { Id = x.Id, Name = x.Name }).ToList();

            var allFaculties = _dbContext.Faculties
                                        .Select(x=> new FacultyViewModel() { Id = x.Id, Name = x.Name }).ToList();

            TagFacultyViewModel viewModel = new TagFacultyViewModel() { Faculties=allFaculties, Tags=allTags};

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TagCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Tag tag = new Tag() { FacultyId = model.FacultyId, Name = model.Name };
                if (await _dbContext.Tags.AddAsync(tag) != null)
                {
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        return RedirectToAction("Index", "Tags");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Enter correct data");
            }
            return RedirectToAction("Index","Tags");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TagEditViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
            else
            {
                ModelState.AddModelError("", "Enter correct data");
            }
            return RedirectToAction("Index", "Tags");
        }
    }
}