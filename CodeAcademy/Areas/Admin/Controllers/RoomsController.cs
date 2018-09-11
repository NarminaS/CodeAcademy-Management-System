using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RoomsController : Controller
    {
        AppDbContext _dbContext;

        public RoomsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var rooms = _dbContext.Rooms
                            .Select(x => new RoomViewModel()
                                { Id = x.Id, Name = x.Name, Capacity = x.Capacity }).ToList();
            return View(rooms);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoomCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Room room = new Room() { Name = model.Name, Capacity = model.Capacity };
                if (await _dbContext.AddAsync(room) != null)
                {
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        return RedirectToAction("Index", "Rooms");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Please, try again");
            }
            return RedirectToAction("Index", "Rooms");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoomViewModel model)
        {
            if (ModelState.IsValid)
            {
                var room = _dbContext.Rooms.Where(x => x.Id == model.Id).SingleOrDefault();
                if (room !=null && room.Name !=model.Name || room.Capacity != model.Capacity)
                {
                    room.Name = model.Name;
                    room.Capacity = model.Capacity;
                    _dbContext.Update(room);
                    if (await _dbContext.SaveChangesAsync() > 0)
                    {
                        return RedirectToAction("Index", "Rooms");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Enter correct data");
            }
            return RedirectToAction("Index", "Rooms");
        }
    }
}