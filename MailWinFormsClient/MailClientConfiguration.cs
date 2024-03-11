using MailWinFormsClient.LetterGetters;
using MailWinFormsClient.LetterSavers;
using MailWinFormsClient.UserGetters;
using Microsoft.Extensions.DependencyInjection;
using WinFormsTestDocsVision;

namespace MailWinFormsClient
{
    internal class MailClientConfiguration
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddTransient<IUserGetter, UsersGetter>();
            services.AddTransient<ILetterSaver, LetterSaver>();
            services.AddTransient<ILetterGetter, LetterGetter>();

            services.AddTransient<MailForm>();
            services.AddTransient<LetterRegistrationForm>();

            return services.BuildServiceProvider();
        }
    }
}
