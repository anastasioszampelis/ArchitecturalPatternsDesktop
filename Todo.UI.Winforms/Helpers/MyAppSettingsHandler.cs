using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.UI.Winforms.Helpers
{
    public interface IMyAppSettingsHandler
    {
        string GetAppName();
    }
    public class MyAppSettingsHandler : IMyAppSettingsHandler
    {
        private readonly string _appName;

        public MyAppSettingsHandler(IOptions<MyAppSettings> options, ILogger<MyAppSettingsHandler> logger)
        {
            _appName = options.Value.AppName;
            logger.LogInformation($"Text read from settings: '{options.Value.AppName}'");
        }

        public string GetAppName()
        {
            return _appName;
        }
    }
}
