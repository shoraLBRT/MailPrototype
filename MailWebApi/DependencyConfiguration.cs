using MailService.Models;
using MailWebApi.DAL;
using MailWebApi.LetterPresenters;
using MailWebApi.Logger;
using MailWebApi.Repository;
using MailWebApi.Validators;
using Microsoft.EntityFrameworkCore;

namespace MailWebApi
{
    public class DependencyConfiguration
    {
        public WebApplicationBuilder CreateAndConfigureBuilder(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MailDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new Exception("ConnectionString Not Found")));

            builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            builder.Services.AddScoped<IRepository<Letter>, LetterRepository>();

            builder.Services.AddTransient<ILetterRegistrar, LetterRegistrar>();
            builder.Services.AddTransient<ILetterPresenter, LetterPresenter>();
            builder.Services.AddTransient<ILetterValidator, LetterValidator>();
            builder.Services.AddTransient<IErrorLogger, ErrorLoggerIntoFile>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            return builder;
        }
    }
}
