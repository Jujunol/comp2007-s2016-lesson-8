using System.Web;
using System.Web.Mvc;

namespace comp2006_s2016_lesson_8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
