using ExoHotel.Data;
using ExoHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Repositories
{
    internal class HotelRepository : IRepository<Hotel, int>
    {
        public void Delete(Hotel entity)
        {
            using ApplicationDbContext context = new ApplicationDbContext();
            context.Hotels.Remove(entity);
            context.SaveChanges();
        }

        public List<Hotel> GetAll()
        {
            using ApplicationDbContext context = new ApplicationDbContext();

            return context.Hotels.ToList();
        }

        public Hotel? GetOneById(int id)
        {
            using ApplicationDbContext context = new ApplicationDbContext();
            return context.Hotels.Find(id);
        }

        public void Save(Hotel entity)
        {
            using ApplicationDbContext context = new ApplicationDbContext();
            context.Hotels.Add(entity);
            context.SaveChanges();
        }

        public void Update(Hotel entity)
        {
            using ApplicationDbContext context = new ApplicationDbContext();
            context.Hotels.Update(entity);
            context.SaveChanges();
        }
    }
}
