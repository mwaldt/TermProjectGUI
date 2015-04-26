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
    public partial class WorkerModWindow : XForm {
        public XForm parentForm { set; get; }
        private Worker workerUpdate;
        
        public WorkerModWindow() {
            InitializeComponent();
            this.regDateBox.Text = GetCurrentDate();
            workerUpdate = new Worker();
        }

        public WorkerModWindow(Worker foundWorker) {
            workerUpdate = foundWorker;
            InitializeComponent();
            this.regDateBox.Text = GetCurrentDate(); //-mw leftoff 4/25
        }

        private void submitButton_Click(object sender, EventArgs e) {
            validateFields();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Hide();
            parentForm.Show();
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
            workerUpdate.BannerID = bannerBox.Text;
            workerUpdate.FirstName = firstNameBox.Text;
            workerUpdate.LastName = lastNameBox.Text;
            workerUpdate.PhoneNumber = phoneBox.Text;
            workerUpdate.Email = emailBox.Text;
            workerUpdate.Credential = credentialBox.Text;
            workerUpdate.InitialRegistrationDate = regDateBox.Text;
            workerUpdate.WorkerPassword = passwordBox.Text;
            workerUpdate.Notes = notesBox.Text;
            workerUpdate.Status = statusBox.Text;
            workerUpdate.DateStatusUpdated = dateStatusBox.Text;
            workerUpdate.Update();
            MessageBox.Show("Worker successfully updated.");
            this.Hide();
            parentForm.Show();
        }
    }
}
