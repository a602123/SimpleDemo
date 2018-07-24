using System;
using System.Collections.Generic;
using System.Text;
using SimpleDemo.Model.DBModels;
using SimpleDemo.Model;
using SimpleDemo.DataProvider;
namespace SimpleDemo.Business
{
    public class UserBusiness : BaseBusiness<TbUser, UserDataProvider>
    {
        public UserBusiness()
        {
        }
    }
}
