using KeystoneBackend.Models;

namespace KeystoneBackend.Services
{
    public interface ICourseRepository
    {
        IReadOnlyCollection<Course> GetCourses();
    }
}
