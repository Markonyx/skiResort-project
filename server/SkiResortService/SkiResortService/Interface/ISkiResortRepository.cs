using SkiResortService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortService.Interface
{
    public interface ISkiResortRepository
    {
        IQueryable<Skiresort> GetSkiResorts();
        Mountain GetById(int id);
        IQueryable<Track> GetTracks(int id);
        IQueryable<Weather> GetWeather(int id);
        IQueryable<Skipass> GetPrice(int id);
        void Reserve(Reservation reservation);
    }
}
