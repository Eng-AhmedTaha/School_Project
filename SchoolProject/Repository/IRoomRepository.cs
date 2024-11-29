using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public interface IRoomRepository
    {
        Task Create(Room room);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<Room>> GetAllAsync();
        Task<Room?> GetByIdAsync(int id);
    }
}
