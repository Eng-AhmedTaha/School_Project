using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public interface ICourseRepository
    {
        Task Create(Course course);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<Course>> GetAllAsync();
        Task<Course?> GetByIdAsync(int id);
    }
}
