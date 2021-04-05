using System.Web;
using System.Web.Mvc;

namespace PetPal_MVC_DB_First
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
