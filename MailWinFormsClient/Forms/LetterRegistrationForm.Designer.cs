namespace MailWinFormsClient
{
    partial class LetterRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SubjectOfLetter = new TextBox();
            Content = new TextBox();
            Registrate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Sender = new ComboBox();
            userBindingSource = new BindingSource(components);
            Recipient = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SubjectOfLetter
            // 
            SubjectOfLetter.Location = new Point(22, 32);
            SubjectOfLetter.Name = "SubjectOfLetter";
            SubjectOfLetter.Size = new Size(457, 27);
            SubjectOfLetter.TabIndex = 0;
            // 
            // Content
            // 
            Content.Location = new Point(23, 145);
            Content.Multiline = true;
            Content.Name = "Content";
            Content.Size = new Size(673, 203);
            Content.TabIndex = 1;
            // 
            // Registrate
            // 
            Registrate.Location = new Point(489, 354);
            Registrate.Name = "Registrate";
            Registrate.Size = new Size(207, 37);
            Registrate.TabIndex = 2;
            Registrate.Text = "Зарегистрировать";
            Registrate.UseVisualStyleBackColor = true;
            Registrate.Click += Registrate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "Тема письма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Отправитель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 62);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Получатель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 122);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "Содержание";
            // 
            // Sender
            // 
            Sender.DropDownStyle = ComboBoxStyle.DropDownList;
            Sender.FormattingEnabled = true;
            Sender.Location = new Point(23, 85);
            Sender.Name = "Sender";
            Sender.Size = new Size(151, 28);
            Sender.TabIndex = 7;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(MailService.Models.User);
            // 
            // Recipient
            // 
            Recipient.DropDownStyle = ComboBoxStyle.DropDownList;
            Recipient.FormattingEnabled = true;
            Recipient.Items.AddRange(new object[] { "" });
            Recipient.Location = new Point(533, 85);
            Recipient.Name = "Recipient";
            Recipient.Size = new Size(151, 28);
            Recipient.TabIndex = 8;
            // 
            // LetterRegistrationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(708, 405);
            Controls.Add(Recipient);
            Controls.Add(Sender);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Registrate);
            Controls.Add(Content);
            Controls.Add(SubjectOfLetter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LetterRegistrationForm";
            Text = "LetterRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SubjectOfLetter;
        private TextBox Content;
        private Button Registrate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox Sender;
        private ComboBox Recipient;
        private BindingSource userBindingSource;
    }
}