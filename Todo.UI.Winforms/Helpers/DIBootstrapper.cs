using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DataAccess.Repositories;
using Todo.Shared.Interfaces;
using Todo.UI.Winforms.Presenters;
using Todo.UI.Winforms.Views;

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
                    services.AddSingleton<ITodoView, TodoView>();
                    services.AddSingleton<IAboutView, AboutView>();
                    services.Configure<MyAppSettings>(context.Configuration);
                    services.AddSingleton<IMyAppSettingsHandler, MyAppSettingsHandler>();

                    services.AddSingleton<ITodoRepository, TodoRepository>();
                    services.AddTransient<TodoPresenter>();
                    services.AddTransient<IAboutPresenter, AboutPresenter>();
                    services.AddTransient(serviceProvider => new Lazy<IAboutPresenter>(() => serviceProvider.GetRequiredService<IAboutPresenter>()));
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
