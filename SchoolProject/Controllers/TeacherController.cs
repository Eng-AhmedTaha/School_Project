using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _roomRepository;

        public TeacherController(ITeacherRepository iteacherRepository)
        {
            _roomRepository = iteacherRepository;
        }

        public async Task<IActionResult> Index()
        {
            var teachers = await _roomRepository.GetAllAsync();
            return View(teachers);
        }


        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            await _roomRepository.Create(teacher);
            return RedirectToAction("Index");
        }



        public async Task<IActionResult> Delete(int id)
        {
            await _roomRepository.DeleteAsync(id);
                return RedirectToAction("Index");   
        }


    }
}
