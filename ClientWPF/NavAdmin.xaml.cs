using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using ClientWPF.AdminServiceReference;

namespace ClientWPF
{
    public partial class NavAdmin : Window
    {
        string _user;

        public NavAdmin(string pasager)
        {
            _user = pasager;
            InitializeComponent();
            label6.Content = "Welcome, " + _user + '!';
        }

        private void addTrainBT_Click(object sender, RoutedEventArgs e)
        {
            var adminProxy = new AdminServiceReference.AdminServiceClient();
            Train t = new Train();
            t.Model = trainModelTB.Text;
            t.Capacity = Convert.ToInt32(trainCapacityTB.Text);
            t.Type = Convert.ToString(trainTypeCB.SelectedItem);
            var status = adminProxy.AddTrain(t);

            if (status == "success")
            {
                label.Foreground = Brushes.Green;
                label.Content = "Successfull";
            }
            else
            {
                label.Foreground = Brushes.Red;
                label.Content = "Incorrect input values!";
            }
            trainModelTB.Text = "Model";
            trainCapacityTB.Text = "Capacity";
            trainTypeCB.SelectedIndex = -1;

        }

        private void addStation_Click(object sender, RoutedEventArgs e)
        {
            var adminProxy = new AdminServiceReference.AdminServiceClient();
            Station st = new Station();
            st.City = stationCityTB.Text.ToString();
            st.Type = stationTypeCB.SelectedItem.ToString();
            var status = adminProxy.AddStation(st);
            if (status == "success")
            {
                label1.Foreground = Brushes.Green;
                label1.Content = "Successful!";
            }
            else
            {
                label1.Foreground = Brushes.Red;
                label1.Content = "Incorrect input values!";
            }
            stationCityTB.Text = "City";
            stationTypeCB.SelectedIndex = -1;
        }

        private void createTrackBT_Click(object sender, RoutedEventArgs e)
        {
            var adminProxy = new AdminServiceReference.AdminServiceClient();
            Track newTrack = new Track();
            newTrack.FromStation = (string)fromStationCB.SelectedItem;
            newTrack.ToStation = (string)toStationCB.SelectedItem;
            newTrack.TimeToLeave = Convert.ToString(hourCB1.SelectedItem) + ":"
                + Convert.ToString(minutesCB1.SelectedItem);
            newTrack.TimeToArrive = Convert.ToString(hourCB2.SelectedItem) + ":"
                + Convert.ToString(minutesCB2.SelectedItem);
            newTrack.Price = priceTB.Text;
            var status = adminProxy.AddTrack(newTrack);

            if (status == "success")
            {
                label5.Foreground = Brushes.Green;
                label5.Content = "Success!";
            }
            else
            {
                label5.Foreground = Brushes.Red;
                label5.Content = "Error occured!";
            }
            fromStationCB.SelectedIndex = -1;
            toStationCB.SelectedIndex = -1;
            hourCB1.SelectedIndex = -1;
            hourCB2.SelectedIndex = -1;
            minutesCB1.SelectedIndex = -1;
            minutesCB2.SelectedIndex = -1;
        }

        private void addStationToTrackBT_Click(object sender, RoutedEventArgs e)
        {
            var adminProxy = new AdminServiceReference.AdminServiceClient();
            Track tr = new Track();
            tr.Name = allTracksCB.SelectedItem.ToString();
            Station st = new Station();
            st.City = betweenStationsCB.SelectedItem.ToString();
            var status = adminProxy.AddStationToTrack(tr, st);

            if (status == "success")
            {
                label4.Foreground = Brushes.Green;
                label4.Content = "Successful!";
            }
            else
            {
                label4.Foreground = Brushes.Red;
                label4.Content = "Error occured!";

            }
        }

        private void allTracksCB_DropDownOpened(object sender, EventArgs e)
        {
            var adminProxy = new AdminServiceClient();
            allTracksCB.Items.Clear();
            var list = adminProxy.GetTracks();
            foreach (var i in list)
                if (!allTracksCB.Items.Contains(i.Name))
                    allTracksCB.Items.Add(i.Name);
        }

        private void betweenStationsCB_DropDownOpened(object sender, EventArgs e)
        {
            var adminProxy = new AdminServiceClient();
            betweenStationsCB.Items.Clear();
            var list = adminProxy.LoadStations();
            foreach (var items in list)
                betweenStationsCB.Items.Add(items.City);
            label4.Content = "";
        }

        private void fromStationCB_DropDownOpened(object sender, EventArgs e)
        {
            var adminProxy = new AdminServiceClient();
            var list = adminProxy.LoadStations();
            foreach (var items in list)
            {
                fromStationCB.Items.Add(items.City);
            }
            label5.Content = "";
        }

        private void toStationCB_DropDownOpened(object sender, EventArgs e)
        {
            var adminProxy = new AdminServiceClient();
            toStationCB.Items.Clear();
            var list = adminProxy.LoadStations();
            foreach (var items in list)
                toStationCB.Items.Add(items.City);
            label5.Content = "";
        }

        private void priceTB_GotFocus(object sender, RoutedEventArgs e)
        {
            priceTB.Text = "";
        }

        private void priceTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (priceTB.Text == "")
                priceTB.Text = "Price";
        }

        private void trainCapacityTB_GotFocus(object sender, RoutedEventArgs e)
        {
            label.Content = "";
            trainCapacityTB.Text = "";
        }

        private void trainCapacityTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (trainCapacityTB.Text == "")
                trainCapacityTB.Text = "Capacity";
        }

        private void trainModelTB_GotFocus(object sender, RoutedEventArgs e)
        {
            label.Content = "";
            trainModelTB.Text = "";
        }

        private void trainModelTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (trainModelTB.Text == "")
            {
                trainModelTB.Text = "Model";
            }
        }

        private void stationCityTB_GotFocus(object sender, RoutedEventArgs e)
        {
            stationCityTB.Text = "";
            label1.Content = "";
        }

        private void stationCityTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (stationCityTB.Text == "")
                stationCityTB.Text = "City";
        }

        private void trainTypeCB_DropDownOpened(object sender, EventArgs e)
        {
            label.Content = "";
            trainTypeCB.Items.Clear();
            trainTypeCB.Items.Add("Personal");
            trainTypeCB.Items.Add("Accelerat");
        }

        private void stationTypeCB_DropDownOpened(object sender, EventArgs e)
        {
            label1.Content = "";
            stationTypeCB.Items.Clear();
            stationTypeCB.Items.Add("Final");
            stationTypeCB.Items.Add("Intermediate");
        }

        private void hourCB1_Loaded(object sender, RoutedEventArgs e)
        {
            hourCB1.Items.Clear();
            for (int i = 1; i <= 24; i++)
                hourCB1.Items.Add(i);
            label5.Content = "";
        }

        private void hourCB2_Loaded(object sender, RoutedEventArgs e)
        {
            hourCB2.Items.Clear();
            for (int i = 1; i <= 24; i++)
                hourCB2.Items.Add(i);
            label5.Content = "";
        }

        private void minutesCB1_Loaded(object sender, RoutedEventArgs e)
        {
            minutesCB1.Items.Clear();
            for (int i = 0; i <= 59; i++)
                if (i < 10)
                    minutesCB1.Items.Add("0" + i);
                else
                    minutesCB1.Items.Add(i);
            label5.Content = "";
        }

        private void minutesCB2_Loaded(object sender, RoutedEventArgs e)
        {
            minutesCB2.Items.Clear();
            for (int i = 0; i <= 59; i++)
                if (i < 10)
                    minutesCB2.Items.Add("0" + i);
                else
                    minutesCB2.Items.Add(i);
            label5.Content = "";
        }

        private void logoffBT_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow nw = new LoginWindow();
            nw.Show();
            this.Close();
        }
    }
}
