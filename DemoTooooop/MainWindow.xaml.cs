using System;
using System.Threading;
using System.Windows;

namespace DemoTooooop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String UserLogin { get; set; }
        public String UserPassword { get; set; }
        public Int32 errorCount = 0;   
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonTryToLoginInAccount_Click(object sender, RoutedEventArgs e)
        {
            UserLogin = TextBoxLogin.Text;
            UserPassword = TextBoxPassword.Text;
            if (UserLogin != "" && UserPassword != "")
            {
                if (SessionData.TryToLoginInAccout(UserLogin, UserPassword))
                {
                    this.Hide();
                    ProductView d = new ProductView();
                    d.Show();
                }
                else
                {
                    errorCount++;
                    if (errorCount > 2)
                    {
                        MessageBox.Show("dfs");
                        Thread.Sleep(1000);
                    }
                    else MessageBox.Show("no");
                }
            }
            else MessageBox.Show("null");         
        }
        private void ButtonContinueAsGuest_Click(object sender, RoutedEventArgs e)
        {
            SessionData.ContAsGuser();
            this.Hide();
            ProductView productView = new ProductView();
            productView.Show();
        }
    }
}
