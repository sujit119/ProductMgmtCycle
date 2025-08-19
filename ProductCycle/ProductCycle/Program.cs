using Microsoft.EntityFrameworkCore;
using ProductCycle.Models;
using ProductCycle.Services;

namespace ProductCycle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ProductDBContext>(db=>db.UseSqlServer(builder.Configuration.GetConnectionString("ProductConnectionString")), ServiceLifetime.Singleton);
            builder.Services.AddScoped<IProductServices,ProductServices>();
            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
