using BirthdayGreetingAPI.Data;
using Mvc.Mailer;

namespace BirthdayGreetingAPI.Mailers
{
    public interface IUserMailer
    {
        MvcMailMessage Birthday(UserFriend friend);                         
        MvcMailMessage PasswordReset();
    }
}