using Newtonsoft.Json;

namespace MailWinFormsClient.UserGetters
{
    internal class UsersGetter : IUserGetter
    {
        private readonly string uriString = "https://localhost:7075/api/Users";
        public async Task<object>? GetUsers()
        {
            try
            {
                var response = await TryGetUsersAsync();

                if (response.IsSuccessStatusCode)
                    return await Deserialize(response);
                else
                {
                    MessageBox.Show($"Ошибка при получении списка пользователей. \n Error: {response.StatusCode}");
                    return null!;
                }
            }
            catch (Exception ex)
            {
                string exString = $"Не удалось получить список пользователей {ex.Message}";
                MessageBox.Show(exString);
                throw new Exception(exString);
            }
        }
        private async Task<HttpResponseMessage> TryGetUsersAsync()
        {
            HttpClient client = new HttpClient();
            return await client.GetAsync(uriString);
        }
        private async Task<object> Deserialize(HttpResponseMessage response)
        {
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject(jsonResponse)!;
        }
    }
}
