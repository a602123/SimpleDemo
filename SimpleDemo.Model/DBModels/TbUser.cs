using System;
using System.Collections.Generic;

namespace SimpleDemo.Model.DBModels
{
    public partial class TbUser
    {
        public uint Id { get; set; }
        public string Username { get; set; }
        public int? State { get; set; }
        public string Email { get; set; }
        public string Telphone { get; set; }
        public string RealName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public uint OrganId { get; set; }
    }
}
