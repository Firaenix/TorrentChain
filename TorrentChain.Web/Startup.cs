using System;
using System.Collections.Generic;
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
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IMapperService, ServiceMapper>();
            MappingRegistry.RegisterMappings();

            services.AddSingleton<BlockSyncServiceImpl>();

            GetAndRegisterBlockChain(services);

            services.AddTransient<IChainService, ChainService>();
            services.AddSingleton<IBroadcastClient, BlockSyncServiceClient>();

            services.AddLogging();
        }

        private void GetAndRegisterBlockChain(IServiceCollection services)
        {
            using (var client = new HttpClient())
            {
                var res = client.GetAsync("http://localhost:5001/api/blockchain/");
                res.Wait();
                var chainStringTask = res.Result.Content.ReadAsStringAsync();
                chainStringTask.Wait();
                var chainList = JsonConvert.DeserializeObject<LinkedList<Block>>(chainStringTask.Result);

                services.AddSingleton<IBlockChain>(new BlockChain(chainList));
            }
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
