using System.IO;
using Microsoft.Extensions.Configuration;

namespace EZching.Data.Configuration
{
    class AppConfiguration
    {
        public static IConfiguration AppSetting { get; }
        static AppConfiguration()
        {

            AppSetting = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json")
                       .Build();

            SQLConnectionString = AppSetting.GetConnectionString("DevConnection");

        }

        //Get DB connection from appsettings.json file
        public static string SQLConnectionString { get; set; }
    }
}
