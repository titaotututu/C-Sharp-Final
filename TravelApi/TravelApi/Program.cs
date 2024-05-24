using TravelApi.Repository;
using Microsoft.EntityFrameworkCore;
using TravelApi.Services;

namespace TravelApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            String? connectionString = builder.Configuration.GetConnectionString("travelDB");
            builder.Services.AddDbContext<TravelContext>(opt => opt.UseMySQL(connectionString));
            //builder.Services.AddScoped<...Service>(); //后期要加上所有
            builder.Services.AddScoped <ITravelService,TravelService> ();
            builder.Services.AddScoped<IJournalService,JournalService>();
            builder.Services.AddScoped<ITodoItemService,TodoItemService>();
            builder.Services.AddScoped<UserService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
