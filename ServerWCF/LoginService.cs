
namespace ServerWCF
{
    public class LoginService : ILoginService
    {
        public string CheckCredentials(User u)
        {
            using (var context = new RailwaySystemModelContainer())
            {
                string status = null;
                foreach (var user in context.Users)
                {
                    if (u.Username == user.Username && u.Password == user.Password && user is Admin)
                        return "Admin";
                    else if (u.Username == user.Username && u.Password == user.Password && user is Passenger)
                        return "Pasager";
                    else
                        status = "Failed";
                }
                return status;
            }

        }
    }
}
