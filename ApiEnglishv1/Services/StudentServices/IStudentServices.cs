using ApiEnglishv1.Models;

namespace ApiEnglishv1.Services.StudentServices
{
    public interface IStudentServices
    {
        Task<List<Student>> GetAllStu(int id);
        //Task<List<Student>> CreateStu(Student student);
    }
}
