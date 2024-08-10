using Microsoft.EntityFrameworkCore;
using ThiThuMayConGa.Model;

namespace ThiThuMayConGa.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DbContextApp _dbContext;
        public StudentRepository(DbContextApp dbContextApp) {
            _dbContext = dbContextApp;
        }
        public async Task AddStudent(Student student)
        {
            await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteStudent(int id)
        {
            var deleteStudent = await GetById(id);
            _dbContext.Students.Remove(deleteStudent);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAll()
        {
            return await _dbContext.Students.ToListAsync();
        }

        public async Task<Student> GetById(int id)
        {
           return await _dbContext.Students.FindAsync(id);
        }

        public async Task UpdateStudent(Student student)
        {
            var updateStudent = await GetById(student.Id);
            _dbContext.Students.Update(updateStudent);
            await _dbContext.SaveChangesAsync();
        }
    }
}
