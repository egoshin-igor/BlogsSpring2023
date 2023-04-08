using Blogs.Application;
using Blogs.Infrastructure;
using Blogs.Infrastructure.Foundation;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Api
{
    public class Program
    {
        public static void Main( string[] args )
        {
            var builder = WebApplication.CreateBuilder( args );

            var connectionString = builder.Configuration.GetConnectionString( "Blogs" );
            builder.Services.AddDbContext<BlogsDbContext>(
                x => x.UseSqlServer( connectionString )
            );

            builder.Services.AddControllers();

            builder.Services.AddApplication();
            builder.Services.AddInfrastructure();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if ( app.Environment.IsDevelopment() )
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapControllers();

            app.Run();
        }
    }
}