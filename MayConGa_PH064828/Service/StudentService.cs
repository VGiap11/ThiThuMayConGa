using ThiThuMayConGa.Model;

namespace MayConGa_PH064828.Service
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient _httpClient;
        public StudentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task AddStudent(Student student)
        {
            await _httpClient.PostAsJsonAsync("api/Student", student);
        }

        public async Task DeleteStudent(int id)
        {
            await _httpClient.DeleteAsync($"api/Student?{id}");
        }

        public async Task<List<Student>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<Student>>("api/Student");
        }

        public async Task<Student> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Student>($"api/Student?{id}");
        }

        public async Task UpdateStudent(Student student)
        {
            await _httpClient.PutAsJsonAsync("api/Student", student);
        }
    }
}
