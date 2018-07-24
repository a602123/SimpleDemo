using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleDemo.Business;
using SimpleDemo.DataProvider;
using SimpleDemo.Model.DBModels;
using SimpleDemo.Model;

namespace SimpleDemo.WebAPI.Controllers
{    
    public class UserController :BaseController<TbUser,UserBusiness,UserDataProvider>
    {
        public UserController():base()
        {

        }
    }
}