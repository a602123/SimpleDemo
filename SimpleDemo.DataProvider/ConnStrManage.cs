using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDemo.DataProvider
{
    public class ConnStrManage
    {
        private static ConnStrManage _instance;

        private string _DB;

        public static string DB
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnStrManage();
                }
                return _instance._DB;
            }
        }

        private ConnStrManage()
        {
            //_DB = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            _DB = "Data Source =192.168.1.234; Initial Catalog =db_edcvim; User Id = sa; Password = qwe123!@#;";

        }
    }
}
