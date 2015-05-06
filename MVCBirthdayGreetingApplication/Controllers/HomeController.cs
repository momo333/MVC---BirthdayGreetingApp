namespace BirthdayGreetingAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Mvc.Mailer;
    using BirthdayGreetingAPI.Mailers;
    using System.Data.Entity;
    using System.Net;
    using BirthdayGreetingAPI.Data;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {

            return View();
        }
        public ActionResult BirthdaysToday(string search)
        {
            FacebookFriendsDBEntities1 db = new FacebookFriendsDBEntities1();
            DateTime today = DateTime.Today;
            
            var searchPeoplewithBirthdaystoday = from UserFriends in db.UserFriends
                                                 where UserFriends.DayOfBirth == today.Day &&
                                                 UserFriends.MonthOfBirth == today.Month
                                                 select UserFriends;
            
            return View(searchPeoplewithBirthdaystoday);
        }
        public ActionResult Contact()
        {
            return View();
        }
       
    }
}