﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace IST.Api
{
    public class Program
    {
        public static void Main(string[] args)
       {
            Console.Title = "API";

            CreateWebHostBuilder(args).UseUrls().Build().Run();



        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                    .UseStartup<Startup>();                   
                    
        }
    }
}