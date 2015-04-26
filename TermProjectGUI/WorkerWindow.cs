using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProjectGUI {
    public partial class WorkerWindow : XForm {
        private Worker workerNew;
        public XForm parentForm;


        public WorkerWindow() {
            InitializeComponent();
            this.worker = new Worker();
        }

        public WorkerWindow(XForm form) {
            InitializeComponent();
            this.worker = new Worker();
            this.parentForm = form;
            this.dateStatusBox.Text = GetCurrentDate();
            this.regDateBox.Text = GetCurrentDate();
        }

        
        private void validateFields() {
            if ((bannerBox.Text == "") || (bannerBox.Text == null)) {
                bannerBox.Focus();
                MessageBox.Show("Enter a banner ID");
            } else if (firstNameBox.Text == "" || firstNameBox.Text == null) {
                firstNameBox.Focus();
                MessageBox.Show("Enter a first name");
            } else if (lastNameBox.Text == "" || lastNameBox.Text == null) {
                lastNameBox.Focus();
                MessageBox.Show("Enter a last name");
            } else if (phoneBox.Text.Length != 12) {
                phoneBox.Focus();
                MessageBox.Show("Invalid phone number, must be formated as 585-555-5555");
            } else if (emailBox.Text == "" || emailBox.Text == null) {
                emailBox.Focus();
                MessageBox.Show("You must enter an email address");
            } else if (credentialBox.SelectedItem == null) {
                credentialBox.Focus();
                MessageBox.Show("Select a credential level for the worker");
            } else if (passwordBox.Text == "" || passwordBox.Text == null) {
                passwordBox.Focus();
                MessageBox.Show("Enter a password");
            } else if (statusBox.SelectedItem == null) {
                bannerBox.Focus();
                MessageBox.Show("Select a Status");
            } else { ProcessUserInput(); }
        }

        private void ProcessUserInput() {
            workerNew.BannerID = bannerBox.Text;
            workerNew.FirstName = firstNameBox.Text;
            workerNew.LastName = lastNameBox.Text;
            workerNew.PhoneNumber = phoneBox.Text;
            workerNew.Email = emailBox.Text;
            workerNew.Credential = credentialBox.Text;
            workerNew.InitialRegistrationDate = regDateBox.Text;
            workerNew.WorkerPassword = passwordBox.Text;
            workerNew.Notes = notesBox.Text;
            workerNew.Status = statusBox.Text;
            workerNew.DateStatusUpdated = dateStatusBox.Text;
            workerNew.Insert();
            MessageBox.Show("Worker successfully added.");
            this.Hide();
            parentForm.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Hide();
            parentForm.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            validateFields();
        }
    }
}
