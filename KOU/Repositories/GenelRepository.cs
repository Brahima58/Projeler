using KOU.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace KOU.Repositories
{
    public class GenelRepository<P> where  P: class, new()
    {
        AContext c = new AContext();
        public List<P> PList()
        {
            return c.Set<P>().ToList();
        }
        public void PEkle(P d)
        {
            c.Set<P>().Add(d);
            c.SaveChanges();
        }
        public void PSil(P d)
        {
            c.Set<P>().Remove(d);
            c.SaveChanges();
        }
        public void PGuncel(P d)
        {
            c.Set<P>().Update(d);
            c.SaveChanges();
        }
        public P PGet(int id)
        {
           return c.Set<P>().Find(id);
        }
        public List<P> Plist(string d)
        {
            return c.Set<P>().Include(d).ToList();
        }

    }
}
