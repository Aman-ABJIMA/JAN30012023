using Student_WEB_API.Data;
using Student_WEB_API.Model;

namespace Student_WEB_API.Repository
{
    public class StudentRepository : IStudentRepository
    {

        private readonly StudentDbContext _studentDbContext;

        public StudentRepository(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }
        public async Task<int> AddStudentAsync(Student studentmodel)
        {
            var studentDetails = new Student()
            {
                Name = studentmodel.Name,
                Roll_No = studentmodel.Roll_No,
                Father_Name = studentmodel.Father_Name,
                Mother_Name = studentmodel.Mother_Name,

                City = studentmodel.City,
                Region = studentmodel.Region,
                PostalCode = studentmodel.PostalCode,

                House_No = studentmodel.House_No,
                Country = studentmodel.Country,
                Contact = studentmodel.Contact

            };
            _studentDbContext._Student.Add(studentDetails);
            await _studentDbContext.SaveChangesAsync();

            return studentDetails.Roll_No;

        }

        public Task DeleteStudentAsync(int rollno)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetAllStudentAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentByRollNoAsync(int roll_no)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudentAsync(int rollno, Student studentModel)
        {
            throw new NotImplementedException();
        }
    }
}
