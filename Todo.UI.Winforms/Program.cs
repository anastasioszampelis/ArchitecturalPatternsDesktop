using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.UI.Winforms.Helpers;

namespace Todo.UI.Winforms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #if DEBUG
            NativeMethods.AllocConsole();
            #endif
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var host = DIBootstrapper.ConfigureDI();
            StartApplication(host);
            //Application.Run(new Form1());
        }

        public static void StartApplication(IHost host)
        {
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var mainForm = services.GetRequiredService<MainForm>();
                    Application.Run(mainForm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        internal static class NativeMethods
        {
            [DllImport("kernel32.dll")]
            internal static extern Boolean AllocConsole();
        }
    }
}
