using SkiResortService.Interface;
using SkiResortService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SkiResortService.Controllers
{
    public class SkiresortsController : ApiController
    {
        ISkiResortRepository _repository;

        public SkiresortsController(ISkiResortRepository repository)
        {
            _repository = repository;
        }

        // GET api/skiresorts
        [Route("api/skiresorts")]
        public IQueryable<Skiresort> GetSkiResorts()
        {
            return _repository.GetSkiResorts();
        }

        // GET api/skiresorts/1
        [Route("api/skiresorts/{id}")]
        public IHttpActionResult GetSkiResortById(int id)
        {
            var skiResort = _repository.GetById(id);
            if(skiResort == null)
            {
                return NotFound();
            }
            return Ok(skiResort);
        }

        // GET api/skiresorts/1/tracks
        [Route("api/skiresorts/{id}/tracks")]
        public IQueryable<Track> GetTracksByMountain(int id)
        {
            return _repository.GetTracks(id);
        }

        // GET api/skiresorts/1/weather
        [Route("api/skiresorts/{id}/weather")]
        public IQueryable<Weather> GetWeatherByMountain(int id)
        {
            return _repository.GetWeather(id);
        }

        // GET api/skiresorts/1/skipass
        [Route("api/skiresorts/{id}/skipass")]
        public IHttpActionResult GetPrice(int id)
        {
            var skipass = _repository.GetPrice(id);
            if(skipass == null)
            {
                return NotFound();
            }
            return Ok(skipass);
        }

        // POST api/skiresorts/{id}/skipass
        [Route("api/skiresorts/{id}/skipass")]
        public void PostReservation(Reservation reservation)
        {
            _repository.Reserve(reservation);
        }
    }
}
