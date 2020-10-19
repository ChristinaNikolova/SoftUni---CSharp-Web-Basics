using SUS.HTTP;
using SUS.MvcFramework;

namespace Suls.Controllers
{
    public class HomeController : Controller
    {
        public HttpResponse Index()
        {
            return this.View();
        }
    }
}
