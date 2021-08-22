using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories.CityRepository;
using Repositories.CountryRepository;
using Repositories.StatServiceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QbDemo
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server = DESKTOP - 7KOSELH; Database = GenoQuickBase; Trusted_Connection = True");
                services.AddScoped<ICityRepository, CityRepository>();
                services.AddScoped<ICountryRepository, CountryRepository>();
                services.AddScoped<IStatServiceRepository, StatServiceRepository>();
            });
        }
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }
}
