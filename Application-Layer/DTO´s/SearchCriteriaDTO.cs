using System.ComponentModel.DataAnnotations;

namespace Application_Layer.DTO_s
{
    public class SearchCriteriaDTO
    {
        public string? CourseId { get; set; }

        [DataType(DataType.Text)]
        public string? Title { get; set; }

        [DataType(DataType.Text)]
        public string? CategoryOrSubject { get; set; }

        [DataType(DataType.Text)]
        public string? Language { get; set; }

        [DataType(DataType.Text)]
        public string? FirstName { get; set; }

        [DataType(DataType.Text)]
        public string? LastName { get; set; }
    }
}
