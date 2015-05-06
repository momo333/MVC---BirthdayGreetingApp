namespace BirthdayGreetingAPI.Controllers
{
    using BirthdayGreetingAPI.Mailers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Mvc.Mailer;
    using BirthdayGreetingAPI.Data;
    public class MailApplicationController : Controller
    {
        private IUserMailer _mailer = new UserMailer();
        public IUserMailer Mailer
        {
            get { return _mailer; }
            set { _mailer = value; }
        }
        public ActionResult Birthday()
        {
            FacebookFriendsDBEntities1 db = new FacebookFriendsDBEntities1();
            DateTime today = DateTime.Today;
            var PeoplewithBirthdaystoday = from UserFriends in db.UserFriends
                                           where UserFriends.DayOfBirth == (int)today.Day &&
                                           UserFriends.MonthOfBirth == (int)today.Month
                                           select UserFriends;
            foreach (UserFriend people in PeoplewithBirthdaystoday)
            {
                Mailer.Birthday(people).Send();

            }
            return RedirectToAction("Index", "Home");
        }
    }
}