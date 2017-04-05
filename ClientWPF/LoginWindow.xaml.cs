using System.Windows;
using ClientWPF.LoginServiceReference;

namespace ClientWPF
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void signupBT_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow newWindow = new SignUpWindow();
            newWindow.ShowDialog();
        }

        private void loginBT_Click(object sender, RoutedEventArgs e)
        {
            var loginProxy = new LoginServiceClient();
            User u = new User();
            u.Username = usernameTB.Text;
            u.Password = passwordBox.Password;
            var status = loginProxy.CheckCredentials(u);

            if (status == "Admin")
            {
                NavAdmin newWindow = new NavAdmin(usernameTB.Text);
                newWindow.Show();
                this.Close();
            }
            if (status == "Pasager")
            {
                NavPasager newWindow = new NavPasager(usernameTB.Text);
                newWindow.Show();
                this.Close();
            }
            if (status == "Failed")
            {
                MessageBox.Show("Login esuat!");
            }
        }

        private void usernameTB_GotFocus(object sender, RoutedEventArgs e)
        {
            usernameTB.Text = "";
        }

        private void usernameTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (usernameTB.Text == "")
                usernameTB.Text = "Username";
        }

        private void PasswordBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = "";
        }

        private void PasswordBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "")
                passwordBox.Password = "Password";
        }
    }
}
