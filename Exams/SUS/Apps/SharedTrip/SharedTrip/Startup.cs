using SUS.HTTP;
using SUS.MvcFramework;
using System.Collections.Generic;

namespace SharedTrip
{
    public class Startup : IMvcApplication
    {
        public void Configure(List<Route> routeTable)
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureCreated();
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
        }
    }
}
