using System;
using System.Collections.Generic;

namespace SimpleDemo.Model.DBModels
{
    public partial class TbLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LineIp { get; set; }
        public int OrganizationId { get; set; }
        public int? LineType { get; set; }
        public int? ServiceProvider { get; set; }
        public int Pingsize { get; set; }
        public int Pingtimes { get; set; }
        public int Timeout { get; set; }
        public int PingInterval { get; set; }
        public bool? ConnectState { get; set; }
        public string Log { get; set; }
        public int AlarmMax { get; set; }
        public DateTime? CheckDate { get; set; }
    }
}
