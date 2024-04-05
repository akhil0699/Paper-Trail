﻿using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Cik.CoreLibs.Extensions;

namespace Cik.Services.Auth.AuthService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().BuildHostConfiguration();
            var host = new WebHostBuilder()
                .UseUrls(config.GetUrlForDocker("auth_server_url"))
                .BuildWebHostBuilder(config)
                .UseConfiguration(config)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}