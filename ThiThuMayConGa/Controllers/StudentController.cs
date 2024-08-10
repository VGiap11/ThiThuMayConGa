using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThiThuMayConGa.Model;
using ThiThuMayConGa.Repository;

namespace ThiThuMayConGa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentrepo;
        public StudentController(IStudentRepository studentRepository) {
               _studentrepo = studentRepository;
        }

        [HttpGet]
        public async Task<List<Student>> GetAll()
        {
            return await _studentrepo.GetAll();
        }

        [HttpGet("id")]
        public async Task<Student> GetById(int id)
        {
            return await _studentrepo.GetById(id);
        }

        [HttpPost]
        public async Task PostStudent(Student student)
        {
            await _studentrepo.AddStudent(student);
        }

        [HttpPut]
        public async Task PutStudent(Student student)
        {
            await _studentrepo.UpdateStudent(student);
        }

        [HttpDelete]
        public async Task DeleteStudent(int id)
        {
            await _studentrepo.DeleteStudent(id);
        }
    }
}
