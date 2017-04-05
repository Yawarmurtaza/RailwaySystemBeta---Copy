using System;

namespace ServerWCF
{
    public class SignUpService : ISignUpService
    {
        public string AddUser(User u, string userType)
        {
            using (var context = new RailwaySystemModelContainer())
            {
                if (userType == "Admin")
                {
                    try
                    {
                        Admin a = new Admin();
                        a.FirstName = u.FirstName;
                        a.LastName = u.LastName;
                        a.Age = u.Age;
                        a.Username = u.Username;
                        a.Password = u.Password;
                        context.Users.Add(a);
                        context.SaveChanges();
                        return "success";
                    }
                    catch (Exception)
                    {
                        return "fail";
                    }
                }
                if (userType == "Pasager")
                {
                    try
                    {
                        Passenger p = new Passenger();
                        p.FirstName = u.FirstName;
                        p.LastName = u.LastName;
                        p.Age = u.Age;
                        p.Username = u.Username;
                        p.Password = u.Password;
                        context.Users.Add(p);
                        context.SaveChanges();
                        return "success";
                    }
                    catch (Exception)
                    {
                        return "fail";
                    }
                }
                return "fail";
            }
        }
    }
}
