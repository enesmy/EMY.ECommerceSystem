using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMY.ECommerceSystem.Infrastructure.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configuration = new();
                configuration.SetBasePath(Directory.GetCurrentDirectory());
                configuration.AddJsonFile("DBConfig.json");
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                return connectionString;
            }
        }
    }
}
