using MailService.Models;
using System.Net.Http.Json;

namespace MailWinFormsClient.LetterSavers
{
    internal class LetterSaver : ILetterSaver
    {
        private readonly string uriString = "https://localhost:7075/api/Mail";
        public async Task SaveLetter(LetterDto letter)
        {
            try
            {
                var letterContent = Serialize(letter);
                var response = await PostSerializedLetter(letterContent);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show($"Письмо зарегистрировано");

                else
                    MessageBox.Show($"Error: {response.StatusCode} \n Вероятно, были некорректно введены необходимые поля.");
            }
            catch (Exception ex)
            {
                string exString = $"Не удалось сохранить письмо {ex.Message}";
                MessageBox.Show(exString);
                throw new Exception(exString);
            }
        }
        private JsonContent Serialize(LetterDto letter) => JsonContent.Create(letter);
        private async Task<HttpResponseMessage> PostSerializedLetter(JsonContent letterContent)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync(uriString, letterContent);
            return response;
        }
    }
}
