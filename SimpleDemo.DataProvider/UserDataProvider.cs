using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDemo.DataProvider
{
    public class UserDataProvider : BaseDataProvider
    {
        public UserDataProvider(string tableName= "tb_user") : base(tableName)
        {
        }

        protected override string InsertStr => throw new NotImplementedException();

        protected override string FieldsStr => throw new NotImplementedException();
    }
}
