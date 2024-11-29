using Microsoft.EntityFrameworkCore;
using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext _context;

        public TeacherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Teacher teacher)
        {
            await _context.teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var teacher  =await  _context.teachers.FindAsync(id);
            if (teacher == null)
            {
                return false; // الطالب غير موجود
            }
          _context.teachers.Remove(teacher);
         
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Teacher>> GetAllAsync()
        {
            return await _context.teachers.ToListAsync();
        }

        public async Task<Teacher?> GetByIdAsync(int id)
        {
            return await _context.teachers.FindAsync(id);
        }
    }
}
