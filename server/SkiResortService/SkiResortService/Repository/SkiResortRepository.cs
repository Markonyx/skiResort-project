using SkiResortService.Interface;
using SkiResortService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkiResortService.Repository
{
    public class SkiResortRepository : IDisposable, ISkiResortRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public Mountain GetById(int id)
        {
            return db.Mountains.SingleOrDefault(m => m._id == id);
        }

        public IQueryable<Skipass> GetPrice(int id)
        {
            return db.Skipasses.Where(s => s.mountain_id == id);
        }

        public IQueryable<Skiresort> GetSkiResorts()
        {
            return db.SkiResorts;
        }

        public IQueryable<Track> GetTracks(int id)
        {
            return db.Tracks.Where(t => t.mountain_id == id);
        }

        public IQueryable<Weather> GetWeather(int id)
        {
            return db.Weathers.Where(w => w.mountain_id == id);
        }

        public void Reserve(Reservation reservation)
        {
            db.Reservations.Add(reservation);
            db.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}