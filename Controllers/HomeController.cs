using Booking_Hotel.Data;
using Booking_Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Booking_Hotel.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.Room = db.Room.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                db.Booking.Add(booking);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(booking);
        }
    }
}