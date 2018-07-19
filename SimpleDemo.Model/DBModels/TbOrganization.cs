using System;
using System.Collections.Generic;

namespace SimpleDemo.Model.DBModels
{
    public partial class TbOrganization
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public uint State { get; set; }
        public string Smstelephone { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
    }
}
