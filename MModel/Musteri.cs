using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MModel
{  

    public class Musteri
    {
        public int MusteriId { get; set; }

        public string Tc { get; set; }

        public string Ad { get; set; }

        public string Adres { get; set; }
 
        public string Telefon { get; set; }

        public string Taahut { get; set; }
        public int? PaketId { get; set; }
        public virtual Paket Paket { get; set; }
    }
   
}
