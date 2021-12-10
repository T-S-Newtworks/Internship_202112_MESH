using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mesh.Models;
using mesh.Models.VM;

namespace mesh.Controllers
{
    public class HomeController : Controller
    {
        private int x = 0;
        private meshContext db = new meshContext();


        public ActionResult test()
        {
            return View();
        }

        public ActionResult Index()
        {
            var model = new Topvm();
            List<Chat> memo = db.Chats.ToList();
            memo.Reverse();
            List<Chat> memocc = new List<Chat>();
            model.Channel = db.Channels.ToList();
            int[] flag = new int[model.Channel.Count];


            foreach (var item in model.Channel)
            {
                foreach (var split in memo)
                {
                    if (split.ChannelNo == item)
                    {
                        memocc.Add(split);
                        break;
                    }
                }
            }

            model.Chats = memocc;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}