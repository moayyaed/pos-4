using POS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Services
{
   public class UserAccountValidation
    {
        Utils.Utils utils = new Utils.Utils();
        public string validateUserDetails(UserModel model)
        {
            string error = null;
            int validPhonenumber = 0;
            switch (model.ValueType)
            {
                case "username":
                    //validating the username
                    if (model.Username.Length <= 0)
                    {
                        error = "username required";
                        model.Valid = false;
                        return error;
                    }
                    else
                    {
                        model.Valid = true;
                        return error;
                    }
                case "phone":
                    if (model.Phone.Length <= 0)
                    {
                        error = "phonenumber required";
                        model.Valid = false;
                        return error;
                    }
                    else if (!int.TryParse(model.Phone, out validPhonenumber))
                    {
                        error = "invalid phonenumber";
                        model.Valid = false;
                        return error;
                    }
                    else if (model.Phone.Length != 10)
                    {
                        error = "maximum of 10 digits required";
                        model.Valid = false;
                        return error;
                    }
                    else
                    {
                        model.Valid = true;
                        return error;
                    }
                case "password":
                    if (model.Password.Length <= 0)
                    {
                        error = "password required";
                        model.Valid = false;
                        return error;
                    }
                    else
                    {
                        model.Valid = true;
                        return error;
                    }
                default:
                    model.Valid = true;
                    return error;
            }

        }

        ///check to see if the form is valid
        ///
        public Boolean IsRegisterFormValid(UserModel model)
        {
            if(model.Username!="" && model.Phone!="" && model.Password!="" && model.Valid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///check the validity of the login form
        ///
        public Boolean IsLoginFormValid(UserModel model)
        {
            if (model.Username != ""  && model.Password != "" && model.Valid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
