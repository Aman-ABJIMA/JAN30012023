using Student_WEB_API.Model;

namespace Student_WEB_API.Repository
{
    public interface IStudentRepository
    {
        Task<int> AddStudentAsync(Student studentModel);
        Task<List<Student>> GetAllStudentAsync();
        Task<Student> GetStudentByRollNoAsync(int rollno);
        Task UpdateStudentAsync(int rollno, Student studentModel);

        Task DeleteStudentAsync(int rollno);
    }
}
