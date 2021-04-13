using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Services
{
   public  class PrepareAccountRegistration
    {
        Model.UserModel model = new Model.UserModel();

        //prepare the user model
        public Model.UserModel FormatInformation(Model.UserModel model)
        {
            model.IsAdmin = "user";
            model.IsActive ="inactive";
            return model;
        }
    }

}
