using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class AccountManagementService
    {
        public void CreateAccount(string email, string password)
        {
            if(!string.IsNullOrEmpty(email)  && !string.IsNullOrEmpty(password))
            {
                try
                {
                    SaveUserInDatabase(email, password);
                }
                catch
                {
                    SendEamilToUser(email);
                }
            }
        }

        private void SaveUserInDatabase(string email, string password)
        {
            //code to add user in database
        }

        private void SendEamilToUser(string email)
        {
            //send welcome email to user
        }
    }
}
