using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;
using SchoolProject.ViewModels;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _iteacherRepository;


        public StudentController(IStudentRepository studentRepository)
        {
            _iteacherRepository = studentRepository;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _iteacherRepository.GetAllAsync();
            return View(students);
        }


        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (!ModelState.IsValid)
            {
               
                return View(student);
            };
            await _iteacherRepository.Create(student);
            return View();
        }



        public async Task<IActionResult> Delete(int id)
        {
            await _iteacherRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }


        public IActionResult Register()
        {
            var viewModel = new RegisterViewModel
            {
                Students = _iteacherRepository.GetAllStudents(), 
                Courses = _iteacherRepository.GetAllCourses()   
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Students = _iteacherRepository.GetAllStudents();
                model.Courses = _iteacherRepository.GetAllCourses();
                return View(model);
            }

            await _iteacherRepository.RegisterAsync(model.StudentId, model.CourseId);
            return RedirectToAction("Register");
        }


    }
}
