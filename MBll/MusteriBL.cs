using MDal;
using MModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBll
{
    public class MusteriBL : IDisposable
    {
        KontrolContext ctx = new KontrolContext();

        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }

        public bool MusteriEkle(Musteri m)
        {
            ctx.Musteriler.Add(m);
            return ctx.SaveChanges() > 0;

        }

        public bool MusteriKaldir(Musteri m)
        {
            ctx.Musteriler.Remove(m);
            return ctx.SaveChanges() > 0;
        }

        public List<Musteri> MusteriListele()
        {

            return ctx.Musteriler.ToList();
            
        }   


        public int SaveChanges()
        {
            return ctx.SaveChanges();
        }
    }
}
