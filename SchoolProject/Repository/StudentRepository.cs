using Microsoft.EntityFrameworkCore;
using SchoolProject.Context;
using SchoolProject.Models;
using SchoolProject.ViewModels;

namespace SchoolProject.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Student student)
        {

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return false; // الطالب غير موجود
            }
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return true;
        }

      
        public async Task<IEnumerable<Student>> GetAllAsync()
        {


            return await _context.Students.ToListAsync();

        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);

        }
        // Register a student to a course
        public async Task RegisterAsync(int studentId, int courseId)
        {
            // إنشاء كائن جديد يمثل العلاقة بين الطالب والدورة
            var studentCourse = new StudentCourse
            {
                StudentId = studentId,
                CourseId = courseId
            };

            // إضافة العلاقة إلى قاعدة البيانات
            await _context.StudentCourses.AddAsync(studentCourse);
            await _context.SaveChangesAsync();
        }


        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }



    }
}
