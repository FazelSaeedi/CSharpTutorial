using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Application;
using LibraryManagement.Application.Contract.Book;
using LibraryManagement.Domain.BookAgg;
using LibraryManagement.Infrastructure.EFCore.Repository;
using System.Linq.Expressions;
using LibraryManagement.Configuration;
using asp_Library.Tools;
using asp_Library.Controllers;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace asp_Library
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

            var connectionString = Configuration.GetConnectionString("aspLibrary");
            LibraryManagementBoostrapper.Configure(services, connectionString);
            services.AddScoped<SecurityPageFilter>();


            var key = Encoding.ASCII.GetBytes("MY_BIG_SECRET_KEY_LKSHDJFLSDKFW@#($)(#)32234");
            AuthenticationBoostrapper.Configure(services, key);


            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{Controller}/{Action}/{id}"
                    );
            });
        }
    }
}
