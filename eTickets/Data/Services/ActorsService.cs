using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;

        }
        public void AddActor(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public Actor GetActorById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllActors()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public void RemoveActor(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actor UpdataActor(int id, Actor actor)
        {
            throw new System.NotImplementedException();
        }


    }
}
