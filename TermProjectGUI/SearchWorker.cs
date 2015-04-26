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
    public partial class SearchWorker : XForm {
        public XForm parentForm { set; get; }
        private string searchCase { set; get; }
        public Worker workerToFind { set; get; }
        public SearchWorker() {
            InitializeComponent();
        }

        public SearchWorker(string searchkey) {
            InitializeComponent();
            this.searchCase = searchkey;
        }

        private void submitButton_Click(object sender, EventArgs e) {
            ValidateInput();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Hide();
            parentForm.Show();
        }

        private void ValidateInput() {
            if (bannerBox.Text == "" || bannerBox.Text == null) {
                bannerBox.Focus();
                MessageBox.Show("Enter a banner ID");
            } else { ProcessSearch(searchCase); }
        }

        private void ProcessSearch(string key) {
            workerToFind = new Worker();
            workerToFind.Populate(bannerBox.Text);
            if(workerToFind.FirstName == "" || workerToFind.FirstName == null){
                MessageBox.Show("Worker with banner ID: {0} was not found, try again", workerToFind.BannerID);
            } else {
                FinalizeSearch(key);
            }
        }

        private void FinalizeSearch(string key) {
            if (key.Equals("Modify")) {
                WorkerModWindow mod = new WorkerModWindow(workerToFind);
                mod.parentForm = this.parentForm;
                this.Hide();
                mod.Show();
            } else if (key.Equals("Delete")) {
                //WorkerDelWindow del = new WorkerDelWindow(workerToFind);
                MessageBox.Show("To be implemented");
            } else {
                MessageBox.Show("Broken code in search worker class, check the key being passed in.");
            }
        }
    }
}
