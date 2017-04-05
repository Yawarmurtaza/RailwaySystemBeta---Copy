using System;
using System.Windows;
using System.Windows.Media;
using ClientWPF.PasagerServiceReference;

namespace ClientWPF
{
    public partial class NavPasager : Window
    {
        string _user;

        public NavPasager(string pasager)
        {
            _user = pasager;
            InitializeComponent();
            label2.Content = "Welcome, " + _user + '!';
        }

        private void bookBT_Click(object sender, RoutedEventArgs e)
        {
            var pasagerProxy = new PasagerServiceClient();
            string number = numberTB.Text;
            User u = new User();
            u.Username = _user;
            Track t = new Track();
            t.Name = tracksCB.SelectedItem.ToString();
            t.TimeToLeave = hoursCB.SelectedItem.ToString();

            var status = pasagerProxy.MakeBooking(u, t, number);

            if (status == "fail")
            {
                label1.Foreground = Brushes.Red;
                label1.Content = "Error occured!";
            }
            else
            {
                label1.Foreground = Brushes.Green;
                label1.Content = "Successful!";
                label3.Content = "Price : " + status;
            }
        }

        private void tracksCB_DropDownOpened(object sender, EventArgs e)
        {
            var serverProxy = new ServerServiceReference.ServerServiceClient();
            tracksCB.Items.Clear();
            var tracks = serverProxy.GetTracks();
            foreach (var item in tracks)
            {
                if (!tracksCB.Items.Contains(item.Name))
                    tracksCB.Items.Add(item.Name);
            }
        }

        private void hoursCB_DropDownOpened(object sender, EventArgs e)
        {
            Track track = new Track();
            var pasagerProxy = new PasagerServiceReference.PasagerServiceClient();
            hoursCB.Items.Clear();
            track.Name = tracksCB.SelectedItem.ToString();
            var list = pasagerProxy.LoadHours(track);
            foreach (var h in list)
                hoursCB.Items.Add(h);
        }

        private void logoffBT_Click(object sender, RoutedEventArgs e)
        {
            var nw = new LoginWindow();
            nw.Show();
            this.Close();
        }

        private void numberTB_GotFocus(object sender, RoutedEventArgs e)
        {
            numberTB.Text = "";
        }

        private void numberTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (numberTB.Text == "")
                numberTB.Text = "No of people";
        }

        private void InfoButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
