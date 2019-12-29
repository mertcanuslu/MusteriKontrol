using MDal;
using MModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBll
{
    public class PaketBL
    {
        KontrolContext ctx = new KontrolContext();

        public List<Paket> PaketleriListele()
        {
            return ctx.Paketler.ToList();
        }
        public bool PaketEkle(Paket p)
        {
            ctx.Paketler.Add(p);
            return ctx.SaveChanges() > 0;

        }
        public bool PaketKaldir(Paket p)
        {
            ctx.Paketler.Remove(p);
            return ctx.SaveChanges() > 0;
        }

        public int SaveChanges()
        {
            return ctx.SaveChanges();
        }
        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }
    }
}
