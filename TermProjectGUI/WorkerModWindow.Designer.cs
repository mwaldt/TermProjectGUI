namespace TermProjectGUI {
    partial class WorkerModWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.credentialBox = new System.Windows.Forms.ComboBox();
            this.dateStatusBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.regDateBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.credentialLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.bannerBox = new System.Windows.Forms.TextBox();
            this.bannerLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.statusBox.SelectedIndex = statusBox.FindStringExact(workerUpdate.Status);
            this.statusBox.Location = new System.Drawing.Point(167, 335);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(227, 24);
            this.statusBox.TabIndex = 53;
            // 
            // credentialBox
            // 
            this.credentialBox.FormattingEnabled = true;
            this.credentialBox.Items.AddRange(new object[] {
            "Administrator",
            "Non-Administrator"});
            this.credentialBox.SelectedIndex = statusBox.FindStringExact(workerUpdate.Credential);
            this.credentialBox.Location = new System.Drawing.Point(168, 221);
            this.credentialBox.Name = "credentialBox";
            this.credentialBox.Size = new System.Drawing.Size(227, 24);
            this.credentialBox.TabIndex = 52;
            // 
            // dateStatusBox
            // 
            this.dateStatusBox.Location = new System.Drawing.Point(167, 365);
            this.dateStatusBox.Name = "dateStatusBox";
            this.dateStatusBox.Text = GetCurrentDate();
            this.dateStatusBox.ReadOnly = true;
            this.dateStatusBox.Size = new System.Drawing.Size(227, 22);
            this.dateStatusBox.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "Date Status Updated";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(19, 338);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 17);
            this.statusLabel.TabIndex = 49;
            this.statusLabel.Text = "Status";
            // 
            // notesBox
            // 
            this.notesBox.AcceptsReturn = true;
            this.notesBox.AcceptsTab = true;
            this.notesBox.Location = new System.Drawing.Point(167, 307);
            this.notesBox.Name = "notesBox";
            this.notesBox.Text = workerUpdate.Notes;
            this.notesBox.Size = new System.Drawing.Size(227, 22);
            this.notesBox.TabIndex = 48;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(19, 310);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(45, 17);
            this.noteLabel.TabIndex = 47;
            this.noteLabel.Text = "Notes";
            // 
            // passwordBox
            // 
            this.passwordBox.AcceptsReturn = true;
            this.passwordBox.AcceptsTab = true;
            this.passwordBox.Location = new System.Drawing.Point(167, 279);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Text = workerUpdate.WorkerPassword;
            this.passwordBox.Size = new System.Drawing.Size(227, 22);
            this.passwordBox.TabIndex = 46;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(19, 282);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 45;
            this.passwordLabel.Text = "Password";
            // 
            // regDateBox
            // 
            this.regDateBox.Location = new System.Drawing.Point(167, 251);
            this.regDateBox.Name = "regDateBox";
            this.regDateBox.ReadOnly = true;
            this.regDateBox.Text = workerUpdate.InitialRegistrationDate;
            this.regDateBox.Size = new System.Drawing.Size(227, 22);
            this.regDateBox.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Registratation Date";
            // 
            // credentialLabel
            // 
            this.credentialLabel.AutoSize = true;
            this.credentialLabel.Location = new System.Drawing.Point(19, 224);
            this.credentialLabel.Name = "credentialLabel";
            this.credentialLabel.Size = new System.Drawing.Size(72, 17);
            this.credentialLabel.TabIndex = 42;
            this.credentialLabel.Text = "Credential";
            // 
            // emailBox
            // 
            this.emailBox.AcceptsReturn = true;
            this.emailBox.AcceptsTab = true;
            this.emailBox.Location = new System.Drawing.Point(167, 193);
            this.emailBox.Name = "emailBox";
            this.emailBox.Text = workerUpdate.Email;
            this.emailBox.Size = new System.Drawing.Size(227, 22);
            this.emailBox.TabIndex = 41;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(19, 196);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 40;
            this.emailLabel.Text = "Email";
            // 
            // phoneBox
            // 
            this.phoneBox.AcceptsReturn = true;
            this.phoneBox.AcceptsTab = true;
            this.phoneBox.Location = new System.Drawing.Point(167, 165);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Text = workerUpdate.PhoneNumber;
            this.phoneBox.Size = new System.Drawing.Size(227, 22);
            this.phoneBox.TabIndex = 39;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(19, 168);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(61, 17);
            this.phoneLabel.TabIndex = 38;
            this.phoneLabel.Text = "Phone #";
            // 
            // lastNameBox
            // 
            this.lastNameBox.AcceptsReturn = true;
            this.lastNameBox.AcceptsTab = true;
            this.lastNameBox.Location = new System.Drawing.Point(167, 137);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Text = workerUpdate.LastName;
            this.lastNameBox.Size = new System.Drawing.Size(227, 22);
            this.lastNameBox.TabIndex = 37;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(19, 140);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 36;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.AcceptsReturn = true;
            this.firstNameBox.AcceptsTab = true;
            this.firstNameBox.Location = new System.Drawing.Point(167, 109);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Text = workerUpdate.FirstName;
            this.firstNameBox.Size = new System.Drawing.Size(227, 22);
            this.firstNameBox.TabIndex = 35;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(19, 112);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 34;
            this.firstNameLabel.Text = "First Name";
            // 
            // bannerBox
            // 
            this.bannerBox.AcceptsReturn = true;
            this.bannerBox.AcceptsTab = true;
            this.bannerBox.Location = new System.Drawing.Point(167, 81);
            this.bannerBox.Name = "bannerBox";
            this.bannerBox.Text = this.workerUpdate.BannerID;
            this.bannerBox.Size = new System.Drawing.Size(227, 22);
            this.bannerBox.TabIndex = 33;
            // 
            // bannerLabel
            // 
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Location = new System.Drawing.Point(19, 84);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(71, 17);
            this.bannerLabel.TabIndex = 32;
            this.bannerLabel.Text = "Banner ID";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(104, 44);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(140, 29);
            this.subtitleLabel.TabIndex = 31;
            this.subtitleLabel.Text = "Add Worker";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(101, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(148, 36);
            this.titleLabel.TabIndex = 30;
            this.titleLabel.Text = "Fast Trax";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(319, 393);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(238, 393);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 28;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // WorkerModWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 426);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.credentialBox);
            this.Controls.Add(this.dateStatusBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.regDateBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.credentialLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.bannerBox);
            this.Controls.Add(this.bannerLabel);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Name = "WorkerModWindow";
            this.Text = "WorkerModWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.ComboBox credentialBox;
        private System.Windows.Forms.TextBox dateStatusBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox regDateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label credentialLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox bannerBox;
        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
    }
}