using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Package_Manager.PackagesService;

namespace Package_Manager.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : MetroWindow
    {
        PackagesService.PackageServiceClient service = new PackageServiceClient();
        BackgroundWorker loginWorker = new BackgroundWorker();
        private string username = string.Empty;
        private string password = string.Empty;
        public LoginWindow()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            loginWorker.WorkerReportsProgress = true;
            loginWorker.WorkerSupportsCancellation = false;
            loginWorker.DoWork += LoginWorker_DoWork;
            loginWorker.ProgressChanged += LoginWorker_ProgressChanged;
            loginWorker.RunWorkerCompleted += LoginWorker_RunWorkerCompleted;

        }

        private void LoginWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                if ((int)e.Result == 1)
                {
                    MessageBox.Show("success!");

                }

            }
        }

        private void LoginWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //while (loginWorker.IsBusy)
            //{
            //    MessageBox.Show("Please Wait");
            //}
        }

        private void LoginWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            int login = 0;
            login = service.Login(username, password);
            loginWorker.ReportProgress(100);
            e.Result = login;

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            username = tbUsername.Text;
            password = tbPassword.Text;
            Mouse.OverrideCursor = Cursors.Wait;
            if (!loginWorker.IsBusy)
            {
                loginWorker.RunWorkerAsync();
            }
            Mouse.OverrideCursor = null;
           

        }
    }
}
