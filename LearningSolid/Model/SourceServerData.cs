using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSolid.Model
{
    public class SourceServerData
    {
        public int Id { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
        public int OrderNumber { get; set; }
        public bool IsDirty { get; set; }

        public string IP { get; set; }

        public int Type { get; set; }
    }
}
