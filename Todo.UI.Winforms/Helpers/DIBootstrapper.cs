using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.UI.Winforms.Helpers
{
    public class DIBootstrapper
    {
        public static IHost ConfigureDI()
        {
            var _host = new HostBuilder()
                .ConfigureAppConfiguration((context, configurationBuilder) =>
                {
                    configurationBuilder.SetBasePath(context.HostingEnvironment.ContentRootPath);
                    configurationBuilder.AddJsonFile("appsettings.json", optional: false);
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<MainForm>();
                    services.Configure<MyAppSettings>(context.Configuration);
                    services.AddSingleton<IMyAppSettingsHandler, MyAppSettingsHandler>();
                })
                .ConfigureLogging(logging =>
                {
                    logging.AddConsole();
                })
                .Build();
            return _host;
        }
    }
}
