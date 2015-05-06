
namespace BirthdayGreetingAPI.Controllers
{
    using BirthdayGreetingAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Net;

    public class WallMessageController : Controller
    {
        //  Block code from developers.facebook.com
        //  post message to the facebook wall
        //
        // GET: /WallMessage/
        public ActionResult Index()
        {
            return View();
        }
        //
        // POST: /WallMessage/Create
        [HttpPost]
        public ActionResult Create(WallMessageModel model)
        {
            try
            {
                var postValues = new Dictionary<string, string>();
                // list of available parameters available @ http://developers.facebook.com/docs/reference/api/post
                postValues.Add("access_token", Session["accessToken"].ToString());
                postValues.Add("message", model.message);

                string facebookWallMsgId = string.Empty;
                string response;
                MethodResult header = Helper.SubmitPost(string.Format("https://graph.facebook.com/{0}/feed", Session["uid"].ToString()),
                                                            Helper.BuildPostString(postValues),
                                                            out response);
                if (header.returnCode == MethodResult.ReturnCode.Success)
                {
                    var deserialised =
                        Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(response);
                    facebookWallMsgId = deserialised["id"];
                    return RedirectToAction("CreatedSuccessfully");
                }
            }
            catch
            {

            }
            return RedirectToAction("WallMessageError");
        }
        public ActionResult CreatedSuccessfully()
        {
            return View();
        }
        public ActionResult WallMessageError()
        {
            return View();
        }

    }
}