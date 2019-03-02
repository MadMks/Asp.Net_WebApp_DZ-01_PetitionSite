using System.Web;
using System.Web.Mvc;

namespace Asp.Net_WebApp_DZ_01_PetitionSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
