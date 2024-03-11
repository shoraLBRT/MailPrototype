namespace WinFormsTestDocsVision
{
    partial class MailForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subjectOfLetterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SentAt = new DataGridViewTextBoxColumn();
            Sender = new DataGridViewTextBoxColumn();
            Recipient = new DataGridViewTextBoxColumn();
            letterOutDtoBindingSource = new BindingSource(components);
            letterDtoBindingSource = new BindingSource(components);
            AllLettersLoadButton = new Button();
            RegistrationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)letterOutDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)letterDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, subjectOfLetterDataGridViewTextBoxColumn, contentDataGridViewTextBoxColumn, SentAt, Sender, Recipient });
            dataGridView1.DataSource = letterOutDtoBindingSource;
            dataGridView1.Location = new Point(12, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(827, 400);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 60;
            // 
            // subjectOfLetterDataGridViewTextBoxColumn
            // 
            subjectOfLetterDataGridViewTextBoxColumn.DataPropertyName = "SubjectOfLetter";
            subjectOfLetterDataGridViewTextBoxColumn.HeaderText = "Тема";
            subjectOfLetterDataGridViewTextBoxColumn.MinimumWidth = 6;
            subjectOfLetterDataGridViewTextBoxColumn.Name = "subjectOfLetterDataGridViewTextBoxColumn";
            subjectOfLetterDataGridViewTextBoxColumn.Width = 150;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            contentDataGridViewTextBoxColumn.HeaderText = "Содержание";
            contentDataGridViewTextBoxColumn.MinimumWidth = 6;
            contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            contentDataGridViewTextBoxColumn.Width = 170;
            // 
            // SentAt
            // 
            SentAt.DataPropertyName = "SentAt";
            SentAt.HeaderText = "Дата и время";
            SentAt.MinimumWidth = 6;
            SentAt.Name = "SentAt";
            SentAt.ReadOnly = true;
            SentAt.Width = 140;
            // 
            // Sender
            // 
            Sender.DataPropertyName = "Sender";
            Sender.HeaderText = "Отправитель";
            Sender.MinimumWidth = 6;
            Sender.Name = "Sender";
            Sender.Width = 125;
            // 
            // Recipient
            // 
            Recipient.DataPropertyName = "Recipient";
            Recipient.HeaderText = "Получатель";
            Recipient.MinimumWidth = 6;
            Recipient.Name = "Recipient";
            Recipient.Width = 125;
            // 
            // letterOutDtoBindingSource
            // 
            letterOutDtoBindingSource.DataSource = typeof(MailWebApi.LetterPresenters.LetterOutDto);
            // 
            // letterDtoBindingSource
            // 
            letterDtoBindingSource.DataSource = typeof(MailService.Models.LetterDto);
            // 
            // AllLettersLoadButton
            // 
            AllLettersLoadButton.Location = new Point(12, 444);
            AllLettersLoadButton.Name = "AllLettersLoadButton";
            AllLettersLoadButton.Size = new Size(213, 36);
            AllLettersLoadButton.TabIndex = 1;
            AllLettersLoadButton.Text = "Загрузка всех писем";
            AllLettersLoadButton.UseVisualStyleBackColor = true;
            AllLettersLoadButton.Click += AllLetterLoadButton_Click;
            // 
            // RegistrationButton
            // 
            RegistrationButton.Location = new Point(551, 444);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(288, 36);
            RegistrationButton.TabIndex = 2;
            RegistrationButton.Text = "Регистрация нового письма";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // MailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 507);
            Controls.Add(RegistrationButton);
            Controls.Add(AllLettersLoadButton);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MailForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)letterOutDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)letterDtoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource letterDtoBindingSource;
        private DataGridViewTextBoxColumn sentAtDataGridViewTextBoxColumn;
        private Button AllLettersLoadButton;
        private BindingSource letterOutDtoBindingSource;
        private Button RegistrationButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectOfLetterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SentAt;
        private DataGridViewTextBoxColumn Sender;
        private DataGridViewTextBoxColumn Recipient;
    }
}
