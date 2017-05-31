using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SpecialBranch.DbContext;
using SpecialBranch.Models;

namespace SpecialBranch.Gateway
{
    public class RpoGateway
    {
        private SbDbContext db = new SbDbContext();

        public int SaveRpo(Rpo rpo)
        {
            db.Rpos.Add(rpo);
            int rowEffected = db.SaveChanges();
            //   throw new NotImplementedException();
            return rowEffected;
        }

        public List<Rpo> GetRpos()
        {
            return db.Rpos.ToList();
            // throw new NotImplementedException();
        }

        public Rpo Details(int? id)
        {
            Rpo rpo = db.Rpos.Find(id);
            return rpo;
        }

        public int Edit(Rpo rpo)
        {
            db.Entry(rpo).State = EntityState.Modified;
            int rowEffected = db.SaveChanges();
            return rowEffected;
        }

        public int Delete(Rpo rpo)
        {
            db.Rpos.Remove(rpo);
            int rowEffected = db.SaveChanges();
            return rowEffected;
        }

        
    }
}