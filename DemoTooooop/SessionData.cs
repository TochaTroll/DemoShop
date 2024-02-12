using System;
using System.Linq;

namespace DemoTooooop
{
    public class SessionData
    {
       public static User CurrentUser { get; set; }
        public static Boolean TryToLoginInAccout(String login, String password)
        {
            User aviableUser = TradeNewEntities.GetContext().User.FirstOrDefault(x=> x.UserLogin == login && x.UserPassword == password);
            if (aviableUser != null)
            {
                CurrentUser = aviableUser;
                return true;
            }
            else return false;
        }
        public static void ContAsGuser()
        {
            CurrentUser = new User()
            {
                UserName = "",
                UserRole = 4,
                Role = TradeNewEntities.GetContext().Role.First(x => x.RoleID == 4)
            };
        }
    }
}
