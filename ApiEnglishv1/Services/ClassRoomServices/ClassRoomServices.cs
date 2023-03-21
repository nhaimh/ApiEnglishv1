using ApiEnglishv1.Data;
using ApiEnglishv1.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEnglishv1.Services.ClassRoomServices
{
    public class ClassRoomServices : IClassRoomServices
    {
        private readonly DataContext _context;
        public ClassRoomServices(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Classroom>> Create(Classroom classroom)
        {
            _context.Classrooms.Add(classroom);
            await _context.SaveChangesAsync();
            return await GetAll();
        }

        public async Task<List<Classroom>> GetAll()
        {
            var classrooms = await _context.Classrooms
                .Include(c => c.Student)
                .ToListAsync();
            return classrooms;
        }
        public async Task<Classroom> GetById(int id)
        {
            var classroom = await _context.Classrooms
                .Where(c => c.Id == id)
                .Include(c => c.Student)
                .SingleAsync();
            return classroom;
        }

        public async Task<List<Classroom>> Delete(int id)
        {
            var clasroom = await _context.Classrooms.FindAsync(id);
            _context.Classrooms.Remove(clasroom);
            await _context.SaveChangesAsync();
            return await GetAll();
        }
        public async Task<List<Classroom>> Update(int id, Classroom request)
        {
            var classroom = await _context.Classrooms.FindAsync(id);

            classroom.Description = request.Description;
            classroom.Student = request.Student;
            classroom.Id = request.Id;
            classroom.Thumbnail = request.Thumbnail;

            await _context.SaveChangesAsync();
            return await GetAll();
        }
    }
}
