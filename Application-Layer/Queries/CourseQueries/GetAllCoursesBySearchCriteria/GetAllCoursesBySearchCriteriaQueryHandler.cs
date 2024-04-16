using AutoMapper;
using Domain_Layer.Models.CourseModel;
using Infrastructure_Layer.Repositories.Course;
using MediatR;

namespace Application_Layer.Queries.CourseQueries.GetAllCoursesBySearchCriteria
{
    public class GetAllCoursesBySearchCriteriaQueryHandler : IRequestHandler<GetAllCoursesBySearchCriteriaQuery, List<CourseModel>>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        public GetAllCoursesBySearchCriteriaQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<List<CourseModel>> Handle(GetAllCoursesBySearchCriteriaQuery request, CancellationToken cancellationToken)
        {
            // Use the repository to fetch courses based on the search criteria
            var courses = await _courseRepository.GetCoursesBySearchCriteria(request.SearchCriteriaInfo);

            // If you need to transform the data before returning it, you can use AutoMapper
            // For example, if the repository returns a list of CourseDTOs, you can map them to CourseModels
            // var courseModels = _mapper.Map<List<CourseModel>>(courses);

            // Return the list of courses
            return courses;
        }

    }
}
