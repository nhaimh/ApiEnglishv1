using System.Text.Json.Serialization;

namespace ApiEnglishv1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Picture { get; set; } = string.Empty;
        [JsonIgnore]
        public Classroom? Classroom { get; set; }
        public int ClassroomId { get; set; }
    }

}
