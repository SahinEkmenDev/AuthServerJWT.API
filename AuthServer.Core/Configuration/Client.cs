using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Configuration
{
    public   class Client
    {
        public string   Id { get; set; }
        public string Secret { get; set; }


           //www.myapi1.com www.myapi2.com eğer  istek  yaptıysak  iki  apiyede erişim sağlanabilir ama sadece bir tanesi  varsa  sadece bir tanesine  erişebilir 
            
        public List<string> Audiences { get; set; }
    }
}
