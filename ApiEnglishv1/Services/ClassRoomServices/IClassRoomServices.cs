using ApiEnglishv1.Models;

namespace ApiEnglishv1.Services.ClassRoomServices
{
    public interface IClassRoomServices
    {
        Task<List<Classroom>> GetAll();
        Task<List<Classroom>> Create(Classroom classroom);
        Task<Classroom> GetById(int id);
        Task<List<Classroom>> Delete(int id);
        Task<List<Classroom>> Update(int id, Classroom request);
    }
}
