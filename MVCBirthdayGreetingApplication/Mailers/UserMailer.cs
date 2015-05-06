using BirthdayGreetingAPI.Data;
using Mvc.Mailer;

namespace BirthdayGreetingAPI.Mailers
{ 
    public class UserMailer : MailerBase, IUserMailer
	{
		public UserMailer()
		{
			MasterName="_Layout";
		}

        public virtual MvcMailMessage Birthday(UserFriend friend)                             
		{
            var mailMessage = new MvcMailMessage { Subject = "Happy Birthday" };
            mailMessage.To.Add(friend.Email);
            ViewBag.Name = friend.Name;
            PopulateBody(mailMessage, viewName: "Birthday");
            return mailMessage;
		}
 
		public virtual MvcMailMessage PasswordReset()
		{
			return Populate(x =>
			{
				x.Subject = "";
				x.ViewName = "";
				x.To.Add("");
			});
		}
       
 	}
}