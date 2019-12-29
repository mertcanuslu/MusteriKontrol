using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MModel
{
    public class Paket
    {
        public int PaketId { get; set; }
        public string PaketAd { get; set; }
        public string PaketFiyat { get; set; }
        public ICollection<Musteri> PaketinMusterileri { get; set; }
        public override string ToString()
        {
            return PaketAd;
        }
    }
    
}
