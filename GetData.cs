using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCourseworkTwo
{
    class GetData
    {
        //Get logged in User's ID
        public static int getUserId()
        {
            String username = "";
            int userId = 0;
            if (File.Exists(@"D:\TempUsers.xml") == true)
            {
                TempUsers dataS = new TempUsers();
                dataS.ReadXml(@"D:\TempUsers.xml");
                TempUsers.UsersRow data = dataS.Users[0];
                username = data.User;

                using (FinanceManagerContainer db = new FinanceManagerContainer())
                {
                    var queryGetUserId = from u in db.Users select u;
                    foreach (var i in queryGetUserId)
                    {
                        if (i.Username.ToString().Equals(username))
                        {
                            userId = (int)i.Id;
                        }
                    }

                }

            }

            return userId;
        }
       
        public static void registerUser(string fname, string lname, string username,string password)
        {
            //Create User Object
            User newUser = new User();
            newUser.FName = fname;
            newUser.LName = lname;
            newUser.Username = username;
            newUser.Password = password;

            //Forwarding the data to the Database by adding that object
            using (FinanceManagerContainer db = new FinanceManagerContainer())
            {
                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }

    }
}
