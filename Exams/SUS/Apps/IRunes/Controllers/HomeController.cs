using SUS.HTTP;
using SUS.MvcFramework;

namespace IRunes.Controllers
{
    public class HomeController : Controller
    {

        public HttpResponse Index()
        {
            return this.View();
        }
    }
}
