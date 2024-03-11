using MailWinFormsClient;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms.Design;

namespace WinFormsTestDocsVision
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = new MailClientConfiguration().ConfigureServices();

            using var form = serviceProvider.GetService<MailForm>()!;
            Application.Run(form);
        }
    }
}