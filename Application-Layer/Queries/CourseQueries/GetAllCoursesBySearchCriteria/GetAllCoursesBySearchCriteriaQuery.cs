using Application_Layer.DTO_s;
using Domain_Layer.Models.CourseModel;
using MediatR;

namespace Application_Layer.Queries.CourseQueries.GetAllCoursesBySearchCriteria
{
    public class GetAllCoursesBySearchCriteriaQuery : IRequest<List<CourseModel>>
    {
        public SearchCriteriaDTO SearchCriteriaInfo { get; }
        public GetAllCoursesBySearchCriteriaQuery(SearchCriteriaDTO _searchCriteria)
        {
            SearchCriteriaInfo = _searchCriteria;
        }
    }
}
