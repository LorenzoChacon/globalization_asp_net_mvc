using GlobalizationDemo.App_Start;
using System.Web;
using System.Web.Mvc;

namespace GlobalizationDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CultureFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
