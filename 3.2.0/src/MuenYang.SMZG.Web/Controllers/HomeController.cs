using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MuenYang.SMZG.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SMZGControllerBase
    {
        //public ActionResult Index()
        //{
        //    return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        //}

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "联系方式：";

            return View();
        }
    }
}