
namespace BirthdayGreetingAPI.Mailers
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Net.Mail;
using BirthdayGreetingAPI.Data;

    public class BirthdayMailer
    {
        /// <summary>
        /// SMTP test for multiple mails 
        /// </summary>
        /// 

        //FacebookFriendsDBEntities1 db = new FacebookFriendsDBEntities1();
        //DateTime today = new DateTime();

        //public void SendMessage()
        //{
        //    var PeoplewithBirthdays = from UserFriends in db.UserFriends
        //                                         where UserFriends.DayOfBirth == (int)today.Day &&
        //                                         UserFriends.MonthOfBirth == (int)today.Month
        //                                         select UserFriends;
        //    foreach (var friend in PeoplewithBirthdays)
        //    {
        //    MailMessage message = new MailMessage();
        //    message.To.Add(friend.Email);
        //    message.Subject = "Happy Birthday";
        //    message.From = new MailAddress("kosevamaria@gmail.com");
        //    StringBuilder builder = new StringBuilder();
        //    builder.AppendLine("Happy Birthday" + friend.Name);
        //    builder.AppendLine("Wishing you all your favourite things on your Big Day!");
        //    builder.AppendLine();
        //    builder.AppendLine("Sent by MvcBot");
        //    message.Body=builder.ToString();
        //    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        //    smtp.Send(message); 
        //    }
        //}

    }
}