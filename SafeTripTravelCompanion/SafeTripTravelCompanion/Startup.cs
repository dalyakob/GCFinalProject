using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using SafeTripTravelCompanion.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SafeTripTravelCompanion.Services;

namespace SafeTripTravelCompanion
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddHttpClient<ICovidTrackingService, ApiCovidTrackingService>(o =>
            {
                o.BaseAddress = new Uri("https://api.covidtracking.com/v1/states/");

                //o.BaseAddress = new Uri(Configuration["Api:BaseAddress"]);
                //o.DefaultRequestHeaders.Add("api-key", Configuration["Api:AccessKey"]);
            });
            services.AddHttpClient<ITripAdvisorService, ApiTripAdvisorService>(o =>
            {
                o.BaseAddress = new Uri("https://tripadvisor1.p.rapidapi.com/locations/");
                o.DefaultRequestHeaders.Add("x-rapidapi-key", "64915844c4mshdaa6d35b1a564efp1c1a6ejsnd1a23a071021");
                //o.BaseAddress = new Uri(Configuration["Api:BaseAddress"]);
                //o.DefaultRequestHeaders.Add("api-key", Configuration["Api:AccessKey"]);
            });
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
