using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webdevelopment_Project.Data;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Controllers
{
    public class CalendarController : Controller
    {
private readonly ApplicationDbContext _context;

        public CalendarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Event
        public IActionResult IndexCalendar()
        {
   
            
                ViewData["events"] = _context.Event;
                {
                    foreach (var item in _context.Event)
                    {
                            new Event { Id = item.Id, Title = item.Title, StartDate = item.StartDate};

                    }
                }
                
            return View();
        }

    }
}
