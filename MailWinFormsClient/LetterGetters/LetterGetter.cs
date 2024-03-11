using Newtonsoft.Json;

namespace MailWinFormsClient.LetterGetters
{
    internal class LetterGetter : ILetterGetter
    {
        private readonly string uriString = "https://localhost:7075/api/Mail";

        public async Task<object?> GetLettersFromWebApi()
        {
            var response = await GetJsonLettersFromWebApi();
            return await DeserializeLetters(response);
        }
        private async Task<HttpResponseMessage> GetJsonLettersFromWebApi()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(uriString);

                if (response.IsSuccessStatusCode)
                    return response;

                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                    throw new Exception(response.StatusCode.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось получить список писем. \n Error: {ex.Message}");
                throw;
            }
        }
        private async Task<object?> DeserializeLetters(HttpResponseMessage response)
        {
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject(jsonResponse);
        }
    }
}
