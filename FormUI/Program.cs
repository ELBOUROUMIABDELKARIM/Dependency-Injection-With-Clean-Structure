using Autofac;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<Dashboard>();
                Application.Run(app);
            }
        }
    }
}
