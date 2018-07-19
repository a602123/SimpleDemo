using System;
using System.Collections.Generic;

namespace SimpleDemo.Model.DBModels
{
    public partial class TbRole
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
