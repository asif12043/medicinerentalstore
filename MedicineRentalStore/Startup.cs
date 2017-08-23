using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicineRentalStore.Startup))]
namespace MedicineRentalStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
