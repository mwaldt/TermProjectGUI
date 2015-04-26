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
    public partial class TransChoiceMenu : XForm {
        XForm parentForm;
        public MainWindow loginView{set; get;}
        public TransChoiceMenu() {
            InitializeComponent();
        }

        public TransChoiceMenu(MainWindow menu) {
            InitializeComponent();
            loginView = menu;
            this.worker = menu.currentWorker;
        }

        private void addWorkerButton_Click(object sender, EventArgs e) {
            WorkerWindow workerWindow = new WorkerWindow();
            workerWindow.parentForm = this;
            workerWindow.Show();
            this.Hide();
        }

        

        private void modWorkerButton_Click(object sender, EventArgs e) {
            SearchWorker workerWindow = new SearchWorker("Modify");
            workerWindow.parentForm = this;
            workerWindow.Show();
            this.Hide();
        }

        private void delWorkerButton_Click(object sender, EventArgs e) {
            SearchWorker workerWindow = new SearchWorker("Delete");
            workerWindow.parentForm = this;
            workerWindow.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            this.Hide();
            this.worker = new Worker();
            loginView.Show();
        }
    }
}
