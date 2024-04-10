﻿using Domain_Layer.Models.CourseModel;
using MediatR;

namespace Application_Layer.Queries.CourseQueries.GetCourseById
{
    public class GetCourseByIdQuery : IRequest<CourseModel>
    {
        public string CourseId { get; private set; }
        public GetCourseByIdQuery(string courseId)
        {
            CourseId = courseId;
        }
    }
}
