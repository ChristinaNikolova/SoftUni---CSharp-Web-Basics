using SUS.HTTP;
using SUS.MvcFramework;

namespace SharedTrip.App.Controllers
{
    public class HomeController : Controller
    {
        public HttpResponse Index()
        {
            return this.View();
        }
    }
}