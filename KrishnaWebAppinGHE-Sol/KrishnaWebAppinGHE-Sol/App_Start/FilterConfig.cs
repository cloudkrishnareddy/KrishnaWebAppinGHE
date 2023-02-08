using System.Web;
using System.Web.Mvc;

namespace KrishnaWebAppinGHE_Sol
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
