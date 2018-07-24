using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDemo.Model
{
    public class PageableData<T>
    {
        public int total { get; set; }
        public IEnumerable<T> rows { get; set; }
    }
}
