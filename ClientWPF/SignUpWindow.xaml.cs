using System;
using System.Windows;
using ClientWPF.SignUpServiceReference;

namespace ClientWPF
{
    public partial class SignUpWindow
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void userTypeCB_Load(object sender, RoutedEventArgs e)
        {
            userTypeCB.Items.Add("Pasager");
            userTypeCB.Items.Add("Admin");
        }

        private void DoneBT_Click(object sender, RoutedEventArgs e)
        {
            var signUpProxy = new SignUpServiceReference.SignUpServiceClient();
            User u = new User();
            u.FirstName = FirstNameTB.Text;
            u.LastName = LastNameTB.Text;
            u.Age = Convert.ToInt32(AgeTB.Text);
            u.Username = UsernameTB2.Text;
            u.Password = PasswordTB2.Text;
            string userType = userTypeCB.SelectedItem.ToString();
            signUpProxy.AddUser(u, userType);
            this.Close();
        }

        private void FirstNameTB_GotFocus(object sender, RoutedEventArgs e)
        {
            FirstNameTB.Text = "";
        }

        private void LastNameTB_GotFocus(object sender, RoutedEventArgs e)
        {
            LastNameTB.Text = "";
        }

        private void AgeTB_GotFocus(object sender, RoutedEventArgs e)
        {
            AgeTB.Text = "";
        }

        private void UsernameTB2_GotFocus(object sender, RoutedEventArgs e)
        {
            UsernameTB2.Text = "";
        }

        private void PasswordTB2_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordTB2.Text = "";
        }

        private void FirstNameTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (FirstNameTB.Text == "")
                FirstNameTB.Text = "First Name";
        }

        private void LastNameTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LastNameTB.Text == "")
                LastNameTB.Text = "Last Name";
        }

        private void AgeTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (AgeTB.Text == "")
                AgeTB.Text = "Age";
        }

        private void UsernameTB2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameTB2.Text == "")
                UsernameTB2.Text = "Username";
        }

        private void PasswordTB2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTB2.Text == "")
                PasswordTB2.Text = "Password";
        }
    }
}
