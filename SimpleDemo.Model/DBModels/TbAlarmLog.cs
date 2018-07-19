using System;
using System.Collections.Generic;

namespace SimpleDemo.Model.DBModels
{
    public partial class TbAlarmLog
    {
        public uint Id { get; set; }
        public string Content { get; set; }
        public DateTime? Time { get; set; }
        public int? AlarmId { get; set; }
    }
}
