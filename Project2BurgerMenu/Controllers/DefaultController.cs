using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Context;
using Project2BurgerMenu.Entities;

namespace Project2BurgerMenu.Controllers
{
    public class DefaultController : Controller
    {
       BurgerMenuContext context=new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            contact.SendDate = DateTime.Now;
            contact.IsRead = false;
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult TodaysOffer()
        {
            var values = context.Products.Where(x => x.DealOfTheDay == true).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMenu()
        {
            var products = context.Products.ToList();
            return PartialView("PartialMenu", products);
        }
        public PartialViewResult PartialCategory()
        {
            var values = context.Categories.Take(6).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialGallery()
        {
            var products = context.Products.Take(6).ToList();
            return PartialView(products);
        }

        public PartialViewResult PartialFooter()
        {
            ViewBag.description = context.Abouts.Select(x => x.Description).FirstOrDefault();
            return PartialView();
        }
        [HttpPost]
        public ActionResult PartialSubscribe(Subscribe subscribe)
        {
            if (ModelState.IsValid)
            {
                context.Subscribes.Add(subscribe);
                context.SaveChanges();

                return RedirectToAction("Index", "Default");
            }

            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult PartialReservation()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialReservation(Reservation reservation)
        {
            reservation.ReservationStatus = "Onay Bekleniyor";
            reservation.PeopleCount = 0;
            reservation.ReservationDate = DateTime.Now;
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return PartialView();
        }
        public PartialViewResult PartialContact()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialLocation()
        {
            ViewBag.mapLocation = context.Abouts.Select(x => x.MapLocation).FirstOrDefault();
            return PartialView();
        }
    }
}