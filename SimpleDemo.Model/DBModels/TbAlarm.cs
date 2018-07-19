using System;
using System.Collections.Generic;

namespace SimpleDemo.Model.DBModels
{
    public partial class TbAlarm
    {
        public uint Id { get; set; }
        public string Ip { get; set; }
        public bool Confirm { get; set; }
        public string Note { get; set; }
        public uint Type { get; set; }
        public string LineName { get; set; }
        public string OrganName { get; set; }
        public int LineId { get; set; }
        public int? OrganId { get; set; }
        public DateTime? RecoverDate { get; set; }
        public int State { get; set; }
        public int AlarmCount { get; set; }
        public DateTime? FirstTime { get; set; }
        public DateTime? LastTime { get; set; }
    }
}
