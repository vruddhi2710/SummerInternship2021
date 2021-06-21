using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;


//in .net 5  no need of namespace program stuff

Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.Configure(app =>
        {
            app.Run(async context =>
            {
                //simulate bad  accessing eg:DB
                //Thread.Sleep(TimeSpan.FromSeconds(10));//We are blocking the web server 
                //Task.Delay(1000);// this also blocks the thread so not good idea  BAD
                await Task.Delay(TimeSpan.FromSeconds(10));// GOOD


                await context.Response.WriteAsync("Hello World");

            });
        });
    })
    .Build().Run();
