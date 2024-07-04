using System.Web;
using System.Web.Mvc;

namespace VdkK22CNT3Lesson11Db2210900032
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
