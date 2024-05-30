﻿using Microsoft.EntityFrameworkCore;
using RailwayReservation.Context;
using RailwayReservation.Interface.Repository;
using RailwayReservation.Model.Domain;

namespace RailwayReservation.Repository
{
    public class StationRepository : IStationRepository
    {
        private readonly RailwayReservationdbContext _context;

        public StationRepository(RailwayReservationdbContext context)
        {
            _context = context;
        }
        public async Task<Station> Add(Station item)
        {
            try{
                _context.Stations.Add(item);
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Station> Delete(Guid key)
        {
            try
            {
                var station = await _context.Stations.FindAsync(key);
                if (station == null)
                {
                    throw new Exception("Station not found");
                }
                _context.Stations.Remove(station);
                await _context.SaveChangesAsync();
                return station;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Station> Get(Guid key)
        {
            try
            {
                var station = await _context.Stations.FindAsync(key);
                return station;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<Station>> GetAll()
        {
            try
            {
                return await _context.Stations.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Station> Update(Station item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
