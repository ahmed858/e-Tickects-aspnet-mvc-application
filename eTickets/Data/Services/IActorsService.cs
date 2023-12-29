using eTickets.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Actor GetActorById(int id);
        void AddActor(Actor actor);
        Actor UpdataActor(int id, Actor actor); 
        void RemoveActor(int id);
    }
}
