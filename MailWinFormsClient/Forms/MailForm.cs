using MailWinFormsClient;
using MailWinFormsClient.LetterGetters;

namespace WinFormsTestDocsVision
{
    internal partial class MailForm : Form
    {
        private readonly LetterRegistrationForm _registrationForm;

        private readonly ILetterGetter _letterGetter;

        public MailForm(LetterRegistrationForm registrationForm, ILetterGetter letterGetter)
        {
            _letterGetter = letterGetter;
            _registrationForm = registrationForm;

            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            _registrationForm.ShowDialog();
        }
        private async void AllLetterLoadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _letterGetter.GetLettersFromWebApi()!;
        }
    }
}
