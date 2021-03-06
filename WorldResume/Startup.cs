using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorldResume.Models;
namespace WorldResume
{
    public class Startup
    {

        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddScoped<ICountryRepository,      MockCountryRepository>();
            //services.AddScoped<IContinentRepository,    MockContinentRepository>();

            services.AddScoped<ICountryRepository,      CountryRepository>();
            services.AddScoped<IContinentRepository,    ContinentRepository>();

            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddControllersWithViews(); //implementeren mvc model

            services.AddDbContext<WorldResumeContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("WorldResumeContext")));
            

            
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // app.UseDefaultFiles();  //gaat op zoek naar een standaard html-pagina zoals index.html

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();  //geeft de foutpagina enkel weer voor de developer
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseNodeModules();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=App}/{action=Index}/{id?}");
            });

        }
    }
}

//insert second mvc course
//finish exercise