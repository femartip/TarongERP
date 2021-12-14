using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.Persistence;
using TarongISW.Services;

namespace TarongISWGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ITarongISWService service = new TarongISWService(new EntityFrameworkDAL(new TarongISWDbContext()));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TarongISWApp(service));
        }
    }
}
