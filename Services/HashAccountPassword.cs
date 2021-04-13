using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrypt;

namespace POS.Services
{
   public class HashAccountPassword
    {
        ScryptEncoder encoder = new ScryptEncoder();

        //hash the user account password to protected value

        public string HashPassword(string password="")
        {
            try
            {
                string hpassword = encoder.Encode(password);
                return hpassword;
            }
            catch (Exception e)
            {

                return e.Message.ToString();
            }
        }

        //compare the user password for security 
        public Boolean  VerifyPassword(string password="",string hpassword="")
        {
            try
            {
                return encoder.Compare(password, hpassword);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
