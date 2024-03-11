using MailService.Models;
using MailWinFormsClient.LetterSavers;
using MailWinFormsClient.UserGetters;
using WinFormsTestDocsVision;

namespace MailWinFormsClient
{
    internal partial class LetterRegistrationForm : Form
    {
        private readonly IUserGetter _userGetter;
        private readonly ILetterSaver _letterSaver;
        public LetterRegistrationForm(IUserGetter userGetter, ILetterSaver letterSaver)
        {
            _userGetter = userGetter;
            _letterSaver = letterSaver;

            InitializeComponent();
            LoadUsers();
        }
        private async void Registrate_Click(object sender, EventArgs e)
        {
            var letter = ConvertInputToLetterDto();

            await _letterSaver.SaveLetter(letter);
            Close();
        }
        private LetterDto ConvertInputToLetterDto()
        {
            string subject = SubjectOfLetter.Text;
            string message = Content.Text;
            int senderId = Sender.SelectedIndex + 1;
            int recipientId = Recipient.SelectedIndex + 1;

            var letter = new LetterDto
            {
                SubjectOfLetter = subject,
                Content = message,
                SenderId = senderId,
                RecipientId = recipientId,
            };

            return letter;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            RefreshInputFields();
        }
        private void RefreshInputFields()
        {
            Sender.SelectedIndex = -1;
            Recipient.SelectedIndex = -1;
            SubjectOfLetter.Clear();
            Content.Clear();
        }
        private async Task LoadUsers()
        {
            var users = await _userGetter.GetUsers();
            var users2 = await _userGetter.GetUsers();
            if (users == null)
            {
                MessageBox.Show("Возникла ошибка при получении списка пользователей");
                return;
            }

            PreparingFields(users, users2);
        }
        private void PreparingFields(object users, object users2)
        {
            Sender.DataSource = users;
            Sender.DisplayMember = "FullName";
            Sender.ValueMember = "Id";
            Sender.SelectedIndex = -1;

            Recipient.DataSource = users2;
            Recipient.DisplayMember = "FullName";
            Recipient.ValueMember = "Id";
            Recipient.SelectedIndex = -1;
        }
    }
}
