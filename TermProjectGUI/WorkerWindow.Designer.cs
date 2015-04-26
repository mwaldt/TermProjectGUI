namespace TermProjectGUI {
    partial class WorkerWindow {
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
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.bannerLabel = new System.Windows.Forms.Label();
            this.bannerBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.credentialLabel = new System.Windows.Forms.Label();
            this.regDateBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dateStatusBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.credentialBox = new System.Windows.Forms.ComboBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(231, 394);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(312, 394);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(94, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(148, 36);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Fast Trax";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(97, 45);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(140, 29);
            this.subtitleLabel.TabIndex = 3;
            this.subtitleLabel.Text = "Add Worker";
            // 
            // bannerLabel
            // 
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Location = new System.Drawing.Point(12, 85);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(71, 17);
            this.bannerLabel.TabIndex = 4;
            this.bannerLabel.Text = "Banner ID";
            // 
            // bannerBox
            // 
            this.bannerBox.AcceptsReturn = true;
            this.bannerBox.AcceptsTab = true;
            this.bannerBox.Location = new System.Drawing.Point(160, 82);
            this.bannerBox.Name = "bannerBox";
            this.bannerBox.Size = new System.Drawing.Size(227, 22);
            this.bannerBox.TabIndex = 5;
            // 
            // firstNameBox
            // 
            this.firstNameBox.AcceptsReturn = true;
            this.firstNameBox.AcceptsTab = true;
            this.firstNameBox.Location = new System.Drawing.Point(160, 110);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(227, 22);
            this.firstNameBox.TabIndex = 7;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 113);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.AcceptsReturn = true;
            this.lastNameBox.AcceptsTab = true;
            this.lastNameBox.Location = new System.Drawing.Point(160, 138);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(227, 22);
            this.lastNameBox.TabIndex = 9;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 141);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Last Name";
            // 
            // phoneBox
            // 
            this.phoneBox.AcceptsReturn = true;
            this.phoneBox.AcceptsTab = true;
            this.phoneBox.Location = new System.Drawing.Point(160, 166);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(227, 22);
            this.phoneBox.TabIndex = 11;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 169);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(61, 17);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone #";
            // 
            // emailBox
            // 
            this.emailBox.AcceptsReturn = true;
            this.emailBox.AcceptsTab = true;
            this.emailBox.Location = new System.Drawing.Point(160, 194);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(227, 22);
            this.emailBox.TabIndex = 13;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 197);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email";
            // 
            // credentialLabel
            // 
            this.credentialLabel.AutoSize = true;
            this.credentialLabel.Location = new System.Drawing.Point(12, 225);
            this.credentialLabel.Name = "credentialLabel";
            this.credentialLabel.Size = new System.Drawing.Size(72, 17);
            this.credentialLabel.TabIndex = 14;
            this.credentialLabel.Text = "Credential";
            // 
            // regDateBox
            // 
            this.regDateBox.Location = new System.Drawing.Point(160, 252);
            this.regDateBox.Name = "regDateBox";
            this.regDateBox.ReadOnly = true;
            this.regDateBox.Size = new System.Drawing.Size(227, 22);
            this.regDateBox.TabIndex = 17;
            this.regDateBox.Text = "2015-04-25";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Registratation Date";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 283);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password";
            // 
            // notesBox
            // 
            this.notesBox.AcceptsReturn = true;
            this.notesBox.AcceptsTab = true;
            this.notesBox.Location = new System.Drawing.Point(160, 308);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(227, 22);
            this.notesBox.TabIndex = 21;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(12, 311);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(45, 17);
            this.noteLabel.TabIndex = 20;
            this.noteLabel.Text = "Notes";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 339);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 17);
            this.statusLabel.TabIndex = 22;
            this.statusLabel.Text = "Status";
            // 
            // dateStatusBox
            // 
            this.dateStatusBox.Location = new System.Drawing.Point(160, 366);
            this.dateStatusBox.Name = "dateStatusBox";
            this.dateStatusBox.ReadOnly = true;
            this.dateStatusBox.Size = new System.Drawing.Size(227, 22);
            this.dateStatusBox.TabIndex = 25;
            this.dateStatusBox.Text = "2015-04-25";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Date Status Updated";
            // 
            // credentialBox
            // 
            this.credentialBox.FormattingEnabled = true;
            this.credentialBox.Items.AddRange(new object[] {
            "Administrator",
            "Non-Administrator"});
            this.credentialBox.Location = new System.Drawing.Point(161, 222);
            this.credentialBox.Name = "credentialBox";
            this.credentialBox.Size = new System.Drawing.Size(227, 24);
            this.credentialBox.TabIndex = 26;
            // 
            // passwordBox
            // 
            this.passwordBox.AcceptsReturn = true;
            this.passwordBox.AcceptsTab = true;
            this.passwordBox.Location = new System.Drawing.Point(160, 280);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(227, 22);
            this.passwordBox.TabIndex = 19;
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.statusBox.Location = new System.Drawing.Point(160, 336);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(227, 24);
            this.statusBox.TabIndex = 27;
            // 
            // WorkerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 431);
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
            this.Name = "WorkerWindow";
            this.Text = "WorkerWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.TextBox bannerBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label credentialLabel;
        private System.Windows.Forms.TextBox regDateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox dateStatusBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox credentialBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.ComboBox statusBox;
    }
}