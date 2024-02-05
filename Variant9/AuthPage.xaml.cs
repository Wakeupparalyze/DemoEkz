using Microsoft.EntityFrameworkCore;
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
using System.Windows.Shapes;
using Variant9.DB;
using Variant9.vm;


namespace Variant9
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Window
    {
        public AuthPage()
        {
            InitializeComponent();
            string login;
            string password;
        }

        private void AuthLikeGuestButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы вошли как гость");
            ListGoods mainWindow = new ListGoods();
            mainWindow.Show();
            this.Close();
        }

        private void AuthClick(object sender, RoutedEventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;
            bool isAuthenticated = CheckUserCredentials(login, password);

            if (isAuthenticated)
            {
                ListGoods mainWindow = new ListGoods();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }   
        private bool CheckUserCredentials(string loginBox, string passwordBox)
        {


            using (var dbContext = new User13Context())
            {
                var user = dbContext.Users.FirstOrDefault(u => u.Login == loginBox && u.Pass == passwordBox);

                return user != null;
            }
        }
    }
}
    