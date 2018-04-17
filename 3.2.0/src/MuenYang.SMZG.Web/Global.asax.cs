using System;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;
using Abp.WebApi.Validation;
using System.Threading;
using Abp.Configuration;
using Abp.Localization;
using System.Globalization;
using System.Web;
using Abp.Extensions;
using Abp.Logging;
using Abp.Timing;

namespace MuenYang.SMZG.Web
{
    public class MvcApplication : AbpWebApplication<SMZGWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );

            base.Application_Start(sender, e);

            //try
            //{
            //    //new AbpApiValidationFilter(AbpBootstrapper.IocManager, null).ExecuteActionFilterAsync(null, default(CancellationToken), null);

            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception);
            //    throw;
            //}
        }

        protected override void Session_Start(object sender, EventArgs e)
        {
            RestoreUserLanguage();
            base.Session_Start(sender, e);
        }

        private void RestoreUserLanguage()
        {
            Response.Cookies.Add(new HttpCookie("Abp.Localization.CultureName", "zh-CN") { Expires = Clock.Now.AddYears(2) });
            //var settingManager = AbpBootstrapper.IocManager.Resolve<ISettingManager>();
            //var defaultLanguage = settingManager.GetSettingValue(LocalizationSettingNames.DefaultLanguage);

            //if (defaultLanguage.IsNullOrEmpty())
            //{
            //    return;
            //}

            //try
            //{
            //    CultureInfo.GetCultureInfo(defaultLanguage);
            //    Response.Cookies.Add(new HttpCookie("Abp.Localization.CultureName", defaultLanguage) { Expires = Clock.Now.AddYears(2) });
            //}
            //catch (CultureNotFoundException exception)
            //{
            //    LogHelper.Logger.Warn(exception.Message, exception);
            //}
        }
    }
}
