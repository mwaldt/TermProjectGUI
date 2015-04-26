using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TermProjectGUI {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        TransChoiceMenu mainMenu;
        public Worker currentWorker { get; set; }
        public MainWindow() {
            InitializeComponent();
            currentWorker = new Worker();
        }

        private void SubmitClick(object sender, RoutedEventArgs e) {
            if (bannerBox.Text == "") { MessageBox.Show("You must enter a banner ID!"); } else if (passwordBox.Password == "") { MessageBox.Show("You must enter a password!"); } else { ProcessLogin(); }
        }

        private void ExitClick(object sender, RoutedEventArgs e) {
            System.Environment.Exit(0);
        }

        private void ProcessLogin() {
            //MessageBox.Show("id: " + bannerBox.Text + "\npw: " + passwordBox.Password);
            
            currentWorker.Populate(bannerBox.Text.Trim());
            if (currentWorker.BannerID == null) { MessageBox.Show("Invalid Worker, enter a valid worker."); }
            else if (!currentWorker.WorkerPassword.Equals(passwordBox.Password.Trim())) {
                MessageBox.Show("Invalid worker/password combination");
            } else {
                //MessageBox.Show("Worker: " + currentWorker.FirstName + " " + currentWorker.LastName + " has logged in.");
                mainMenu = new TransChoiceMenu(this);
                this.Hide();
                mainMenu.Show();
            }
            
        }

        public void LogoutWorker() {
            this.currentWorker = new Worker();
        }
    }
}
