using System.Web;
using System.Web.Mvc;

namespace NOSTRA_IoT_Platform
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
