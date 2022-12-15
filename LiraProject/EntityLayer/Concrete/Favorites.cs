using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Favorites
    {
        [Key]
        public int FavoriteID { get; set; }
        public Customer Customer { get; set; } 
        public Companies Companies { get; set; }
    }
}
