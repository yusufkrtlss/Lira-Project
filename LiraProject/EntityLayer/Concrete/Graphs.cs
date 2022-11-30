using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Graphs
    {
        public int GraphId { get; set; }
        public string GraphName { get; set; }
        public Companies Company { get; set; }
    }
}
