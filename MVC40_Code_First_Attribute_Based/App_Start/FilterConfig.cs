using System.Web;
using System.Web.Mvc;

namespace MVC40_Code_First_Attribute_Based
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}