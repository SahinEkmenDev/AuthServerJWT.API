using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Models
{
    public class product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Price     { get; set; }
        public int Stock { get; set; }
        public int UserId { get; set; }

    }
}
