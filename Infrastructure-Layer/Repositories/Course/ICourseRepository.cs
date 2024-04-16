using Domain_Layer.Models.CourseModel;
using Application_Layer.DTO_s;

namespace Infrastructure_Layer.Repositories.Course
{
    public interface ICourseRepository
    {
        Task DeleteCourseByIdAsync(string courseId);
        Task AddCourseAsync(CourseModel course);
        Task<CourseModel> GetCourseByIdAsync(string courseId);
        Task<List<CourseModel>> GetCoursesBySearchCriteria(SearchCriteriaDTO searchCriteriaInfo);
        // Task<List<CourseModel>> GetCoursesBySearchCriteria(string searchCriteria);
        // Task<List<CourseModel>> GetCoursesBySearchCriteria(SearchCriteriaDTO criteria);
    }
}
