using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TorrentChain.Web.Mapper;
using TorrentChain.Service;
using TorrentChain.Service.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;
using TorrentChain.Data.Models;
using TorrentChain.Service.Mapper;
using MappingRegistry = TorrentChain.Web.Mapper.MappingRegistry;

namespace TorrentChain.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IMapperService, ServiceMapper>();
            MappingRegistry.RegisterMappings();

            services.AddSingleton<IBlockChain, BlockChain>();
            services.AddTransient<IChainService, ChainService>();


            services.AddSingleton<BlockSyncServiceImpl>();
            services.AddSingleton<BlockSyncServiceClient>();
            services.AddSingleton<IBroadcastClient, BlockSyncServiceClient>();

            // services.AddTransient<IChainResolutionService, S3ChainResolutionService>();
            services.AddTransient<IChainResolutionService, PeerChainResolutionService>();

            services.AddLogging();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
