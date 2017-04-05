using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClientCUI.AdminServiceReference;
using ClientCUI.LoginServiceReference;
using ClientCUI.PasagerServiceReference;
using ClientCUI.ServerServiceReference;
using ClientCUI.SignUpServiceReference;
using ServerWCF;

namespace ClientCUI
{
    class Program
    {
        private static string _user;
        static LoginServiceClient loginProxy = new LoginServiceClient();
        static AdminServiceClient adminProxy = new AdminServiceClient();
        static SignUpServiceClient signUpProxy = new SignUpServiceClient();
        static PasagerServiceClient pasagerProxy = new PasagerServiceClient();
        static ServerServiceClient serverProxy = new ServerServiceClient();
        static void Main(string[] args)
        {
            LoginScreen();            
        }

        private static void LoginScreen()
        {
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Sign up");
            Console.WriteLine("0.Exit");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    string status = Login();
                    if (status == "Admin")
                        AdminScreen();
                    else if (status == "Pasager")
                        PasagerScreen();
                    else if (status == "fail")
                        Console.WriteLine("Login failed");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    SignUp();
                    LoginScreen();
                    break;
                case "0":
                    Console.WriteLine("Thanks for your visit!");
                    Console.ReadKey();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Optiune invalida!");
                    break;
            }
        }

        private static void AdminScreen()
        {
            int op;
            do
            {
                Console.WriteLine("1.Add train");
                Console.WriteLine("2.Add Station");
                Console.WriteLine("3.Add Track");
                Console.WriteLine("4.Add new station to track");
                Console.WriteLine("0.Return");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine(AddTrainScreen());
                        break;
                    case 2:
                        Console.WriteLine(AddStationScreen());
                        break;
                    case 3:
                        Console.WriteLine(AddTrackScreen());
                        break;
                    case 4:
                        Console.WriteLine(AddStationToTrackScreen());
                        break;
                    case 0:
                        Console.Clear();
                        LoginScreen();
                        break;
                    default:
                        Console.WriteLine(">Invalid option!");
                        AdminScreen();
                        break;
                }
            } while (op != 0);
        }

        private static void PasagerScreen()
        {
            int op;
            do
            {
                Console.WriteLine("1.See tracks");
                Console.WriteLine("2.Make a booking");
                Console.WriteLine("0.Return");
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    var list = serverProxy.GetTracks();
                    foreach (var item in list)
                    {
                        Console.Write("\t" + item.Name + "\t" + item.TimeToLeave + "\t" + item.TimeToArrive);
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
                else if (op == 2)
                {
                    Track t = new Track();
                    Console.Write("Track: ");
                    t.Name = Console.ReadLine();
                    Console.Write("Leaving hour: ");
                    t.TimeToLeave = Console.ReadLine();
                    Console.Write("Number of persons: ");
                    string number = Console.ReadLine();
                    User u = new User();
                    u.Username = _user;
                    try
                    {
                        pasagerProxy.MakeBooking(u, t, number);
                        Console.Clear();
                        PasagerScreen();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unable to book!");
                    }
                }
                else
                {
                    Console.Clear();
                    if (op != 0)
                    {
                        Console.WriteLine("Invalid option!");
                        LoginScreen();
                    }
                }
            } while (op != 0);
        }

        public static string Login()
        {
            string status;
            User u1 = new User();
            Console.Write("Username: ");
            u1.Username = Console.ReadLine();
            Console.Write("Password: ");
            u1.Password = Console.ReadLine();
            status = loginProxy.CheckCredentials(u1);
            Console.Clear();
            if (status == "Admin" || status == "Pasager")
            {
                _user = u1.Username;
                return status;
            }
            else
            {
                return "fail";
            }
        }

        private static void SignUp()
        {
            string status;
            User u2 = new User();
            Console.Write("Admin/Pasager: ");
            string tip = Console.ReadLine();
            Console.Write("First name: ");
            u2.FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            u2.LastName = Console.ReadLine();
            Console.Write("Age: ");
            u2.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Username: ");
            u2.Username = Console.ReadLine();
            Console.Write("Password: ");
            u2.Password = Console.ReadLine();
            status = signUpProxy.AddUser(u2, tip);
            Console.Clear();
            if (status == "success")
                Console.WriteLine("Sign up successful!");
            else
            {
                Console.WriteLine("Sign up failed!");
            }
        }

        private static string AddTrainScreen()
        {
            Train t = new Train();
            Console.Clear();
            Console.Write(">Train model: ");
            t.Model = Console.ReadLine();
            Console.Write(">Capacity: ");
            t.Capacity = Convert.ToInt32(Console.ReadLine());
            Console.Write(">Personal/Accelerat: ");
            t.Type = Console.ReadLine();
            return adminProxy.AddTrain(t);
        }

        private static string AddStationScreen()
        {
            Station st = new Station();
            Console.Clear();
            Console.Write(">City: ");
            st.City = Console.ReadLine();
            Console.Write(">Final/Intermediate: ");
            st.Type = Console.ReadLine();
            return adminProxy.AddStation(st);
        }

        private static string AddTrackScreen()
        {
            Track newTrack = new Track();
            Console.Clear();
            Console.WriteLine("Available stations:");
            var list = adminProxy.LoadStations();
            foreach(var item in list)
                Console.WriteLine("\t"+item);
            Console.WriteLine();
            Console.Write(">From station: ");
            newTrack.FromStation = Console.ReadLine();
            Console.Write(">To station: ");
            newTrack.ToStation = Console.ReadLine();
            Console.Write(">Leaving time(hh:mm): ");
            newTrack.TimeToLeave = Console.ReadLine();
            Console.Write(">Arriving time(hh:mm): ");
            newTrack.TimeToArrive = Console.ReadLine();
            Console.Write(">Price: ");
            newTrack.Price = Console.ReadLine();
            return adminProxy.AddTrack(newTrack);
        }

        private static string AddStationToTrackScreen()
        {
            Console.Clear();
            Track tr = new Track();
            Station st = new Station();

            Console.WriteLine("All tracks: ");
            var list1 = serverProxy.GetTracks();
            foreach (var item in list1)
            {
                Console.WriteLine("\t"+item);
            }
            Console.Write(">Select a track: ");
            tr.Name = Console.ReadLine();

            Console.WriteLine("All stations: ");
            var list2 = serverProxy.LoadStations();
            foreach (var item in list2)
            {
                Console.WriteLine("\t" + item);
            }
            Console.Write(">Select a station: ");
            st.City = Console.ReadLine();
            return adminProxy.AddStationToTrack(tr, st);
        }

    }
}
