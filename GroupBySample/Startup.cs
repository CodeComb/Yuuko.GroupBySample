using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(GroupBySample.Startup))]

namespace GroupBySample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapYuuko();
        }
    }
}
