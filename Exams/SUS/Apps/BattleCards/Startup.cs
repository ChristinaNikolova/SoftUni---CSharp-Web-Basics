using BattleCards.Data;
using SUS.HTTP;
using SUS.MvcFramework;
using System.Collections.Generic;

namespace BattleCards
{
    public class Startup : IMvcApplication
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
        }

        public void Configure(List<Route> routeTable)
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureCreated();
        }
    }
}
