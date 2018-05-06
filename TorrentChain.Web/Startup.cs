using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TorrentChain.Web.Mapper;
using TorrentChain.Service;
using TorrentChain.Service.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using TorrentChain.Data.Models;
using TorrentChain.Service.Mapper;
using MappingRegistry = TorrentChain.Web.Mapper.MappingRegistry;

namespace TorrentChain.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            

            services.AddMvc();

            services.AddSingleton<IMapperService, ServiceMapper>();
            MappingRegistry.RegisterMappings();

            StupidMansBlockchainBootstrapper(services);

            services.AddSingleton<BlockSyncServiceImpl>();
            services.AddSingleton<IBroadcastClient, BlockSyncServiceClient>();
            services.AddTransient<IChainService, ChainService>();
            
            services.AddLogging();
        }

        private void StupidMansBlockchainBootstrapper(IServiceCollection services)
        {
            var crapChain = new BlockChain(null);

            var serviceClient = new ChainResolveServiceClient(Configuration, new ChainResolveImpl(crapChain), new ServiceMapper());
            var chain = serviceClient.ResolveChainFromPeers();

            services.AddSingleton<IBlockChain>(chain);
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
