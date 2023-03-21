using ApiEnglishv1.Data;
using ApiEnglishv1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


namespace ApiEnglishv1.Services.StudentServices
{
    public class StudentServices : IStudentServices
    {
        private readonly DataContext _context;
        public StudentServices(DataContext context)
        {
            _context = context;
        }

        //public async Task<List<Student>> CreateStu(Student student)
        //{
        //    _context.Students.Add(student);
        //    await _context.SaveChangesAsync();
        //    return await GetAllStu(student.Classroomid);
        //}

        public async Task<List<Student>> GetAllStu(int id)
        {
            var students = await _context.Students
                 .Where(c => c.ClassroomId == id)
                 .ToListAsync();

            return students;
        }

    }
}
