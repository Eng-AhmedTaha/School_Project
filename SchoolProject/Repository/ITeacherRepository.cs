using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public interface ITeacherRepository
    {
        Task Create( Teacher teacher );
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<Teacher>> GetAllAsync();   
        Task<Teacher?> GetByIdAsync(int id);
    }
}
