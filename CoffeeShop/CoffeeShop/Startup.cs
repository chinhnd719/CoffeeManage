using CoffeeShop.Application.Interfaces;
using CoffeeShop.Application.Services;
using CoffeeShop.Domain.Interfaces;
using CoffeeShop.Infrastructure.EF;
using CoffeeShop.Infrastructure.Persistence;
using CoffeeShop.Infrastructure.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop
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

            services.AddAuthentication("CookieAuth")
                .AddCookie("CookieAuth", config =>
           {
               config.Cookie.Name = " Chinh.Cookie";
               config.LoginPath = "/Home/Index";
            });
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddMvc();
            services.AddDbContext<CoffeeShopDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DataConnection")));
            services.AddScoped<INhanVienRepository, NhanVienRepository>();
            services.AddScoped<INhanVienServices, NhanVienServices>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IMenuServices, MenuServices>();
            services.AddScoped<IChiTietNhapRepository, ChiTietNhapRepository>();
            services.AddScoped<IChiTietNhapServices, ChiTietNhapServices>();
            services.AddScoped<IHoaDonRepository, HoaDonRepository>();
            services.AddScoped<IHoaDonServices, HoaDonServices>();
            services.AddScoped<ICTHDRepository, CTHDRepository>();
            services.AddScoped<ICTHDServices, CTHDServices>();
            services.AddScoped<IPhanCaRepository, PhanCaRepository>();
            services.AddScoped<IPhanCaServices, PhanCaServices>();
            services.AddScoped<IBangLuongRepository, BangLuongRepository>();
            services.AddScoped<IBangLuongServices, BangLuongServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Admin}/{action=Login}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
