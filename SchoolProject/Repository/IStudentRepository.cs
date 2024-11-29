using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public interface IStudentRepository
    {
        // Create a new student
        Task Create(Student student);

        // Delete a student by ID
        Task<bool> DeleteAsync(int id);



        // Get all students
        Task<IEnumerable<Student>> GetAllAsync();

        // Get a student by ID
        Task<Student?> GetByIdAsync(int id);

        // Register a student to a course
        Task RegisterAsync(int studentId, int courseId);

        // Get all students for dropdown
        IEnumerable<Student> GetAllStudents();

        // Get all courses for dropdown
        IEnumerable<Course> GetAllCourses();
    }
}
