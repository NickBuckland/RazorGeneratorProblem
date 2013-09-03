using System.Web.Mvc;

namespace MvcWebRoot.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "MvcWebRoot.Areas.Admin.Controllers", "PreCompiledView.Controllers" }
            );
        }
    }
}
