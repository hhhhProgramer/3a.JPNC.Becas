using Control;
using Control.Repositories;
using Couchbase.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


namespace View
{
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) 
        {
            
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = new System.TimeSpan(0,0,25);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddControllersWithViews();

            services.AddDbContextPool<AppDbContext> (
                option => {
                    option.UseMySql(Configuration.GetConnectionString ("EFDbMysqlConnection"));
                }
            );

            services.AddRazorPages ();

            services.AddScoped<AppDbContext> ();
            services.AddScoped (typeof (IRepository<>), typeof (SQLRepository<>));
            services.AddScoped<IEvaluatorRepository, EvaluatorControl> ();
            services.AddScoped<IVisitRepository, VisitControl> ();
            services.AddScoped<IStudentRepository, StudentContainer> ();
            services.AddScoped<IAccoutRepository, AccoutControl> ();
            services.AddScoped<IEconomicStudyRepository, EconomicStudyControl> ();
            
            services.AddRouting (option => {
                option.LowercaseUrls = true;
                option.LowercaseQueryStrings = true;
                option.AppendTrailingSlash = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            

            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseExceptionHandler ("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts ();
            }

            app.UseHttpsRedirection ();
            app.UseStaticFiles ();

            app.UseRouting ();

            app.UseAuthorization ();
            app.UseSession();

            app.UseEndpoints (endpoints => {
                endpoints.MapRazorPages ();
            });
            
        }

    }
}