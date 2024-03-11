namespace MailWebApi.Logger
{
    public class ErrorLoggerIntoFile : IErrorLogger
    {
        public void LogError(Exception ex)
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(folderPath, "ErrorLog.txt");
            try
            {
                if (!File.Exists(filePath))
                    File.Create(filePath).Dispose();

                WriteErrorIntoFile(filePath, ex);
            }
            catch (IOException ioEx)
            {
                WriteErrorIntoFile(Path.Combine(folderPath, ioEx.Message), ioEx);
            }
        }
        private void WriteErrorIntoFile(string filePath, Exception ex)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
                sw.WriteLine($"{DateTime.Now}: {ex.Message}");
        }
    }
}
