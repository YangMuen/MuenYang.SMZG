using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuenYang.SMZG.Web.Controllers
{
    public class SWTYController : SMZGControllerBase
    {
        // GET: Album
        public ActionResult Index()
        {
            SetBrowserTypeViewBag();
            SetNewItemList();
            return View();
        }

        public ActionResult Detail(string albumName)
        {
            SetBrowserTypeViewBag();
            SetAlbumItemList(albumName);
            return View();
        }

        public ActionResult GridPageListJson()
        {
            try
            {
                string filepath = Server.MapPath("~/App_Data/TestAlbum.json");
                string json = GetFileJson(filepath);
                return Content(json);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ActionResult SwtychinaTime()
        {
            SetBrowserTypeViewBag();
            return View();
        }

        public ActionResult SwtychinaAlbum()
        {
            SetBrowserTypeViewBag();
            return View();
        }
    }
}